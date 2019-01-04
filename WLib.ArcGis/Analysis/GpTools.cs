﻿/*---------------------------------------------------------------- 
// auth： Windragon
// date： 2018
// desc： None
// mdfy:  None
//----------------------------------------------------------------*/

using System;
using System.Text;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.ConversionTools;
using ESRI.ArcGIS.DataManagementTools;
using ESRI.ArcGIS.esriSystem;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.Geoprocessing;
using ESRI.ArcGIS.Geoprocessor;
using WLib.ArcGis.GeoDb.WorkSpace;
using WLib.Attributes;

namespace WLib.ArcGis.Analysis
{
    //------------------------------------GP工具调用成功条件总结----------------------------------------
    //执行GP操作前先在ArcMap上运行一遍，并确定是否符合以下条件：
    //重点：数据路径不能有空格，路径不能太深的！！！
    //①若是ArcGIS 10.0，要安装SP5
    //②Lincense权限：Products为权限最高的ArcInfo(在License控件中不要同时选中其他项)， 并选择扩展项：Spatial Analyst
    //③GP操作参数是否有误，具体参考ArcMap中调用该工具的帮助：
    //  1)whereClause参数的sql语句是否有误;
    //  2)输入输出参数有些情况不能为featureClass或featureLayer，有些情况则不能为路径；
    //  3)当参数为路径时，确保路径存在，有些文件名参数不能加上".shp"；
    //  4)要素类名称开头是英文，不能是数字；
    //④GP结果输出目录是否存在，输出位置是否存在同名文件/图层
    //⑤GP操作和输出的文件/要素类是否被锁定
    //⑥坐标系是否一致，除坐标系名称外，具体坐标系参数也必须一致
    //⑦数据问题：不能有空几何等情况，注意使用几何修复
    //⑧特殊情况：安装Desktop和SDK后，再安装AE Runtime，则GP工具调用失败且程序直接崩溃，卸载Runtime后，GP工具调用成功
    //--------------------------------------------------------------------------------------------------

    /// <summary>
    /// GP操作（Geoprocessor）
    /// </summary>
    public class GpTools
    {
        /// <summary>
        /// 地理处理（GP）
        /// </summary>
        public Geoprocessor Geoprocessor { get; set; } = new Geoprocessor();
        /// <summary>
        /// 输出时是否覆盖同名文件
        /// </summary>
        public bool OverrideOutPut { get => Geoprocessor.OverwriteOutput; set => Geoprocessor.OverwriteOutput = value; }
        /// <summary>
        /// 获取GP工具的执行结果信息
        /// </summary>
        /// <param name="result">GP工具执行结果</param>
        /// <returns></returns>
        public virtual string GetGpMessage(IGeoProcessorResult result)
        {
            var sb = new StringBuilder();
            if (result != null)
            {
                if (result.Status == esriJobStatus.esriJobSucceeded)
                {
                    for (int i = 0; i <= result.MessageCount - 1; i++)
                    {
                        sb.AppendLine(result.GetMessage(i));
                    }
                }
            }
            else
            {
                sb.AppendLine("GP可能运行出错，GP结果信息为空！");
            }
            return sb.ToString();
        }


        #region 要素转线，这三个方法暂未测试通过
        /// <summary>  
        /// 面转线
        /// </summary> 
        /// <param name="inFeatureClassPath">输入要素类的路径（eg:D:\xx.mdb\xx或D:\xx.shp）</param>
        /// <param name="outputPath">输出要素类的路径（eg:D:\xx.mdb\xx或D:\xx.shp）</param>
        /// <returns></returns>  
        [Obsolete("该方法暂未测试通过")]
        public IGeoProcessorResult PolygonToPolyline(string inFeatureClassPath, string outputPath)
        {
            PolygonToLine polygonToLine = new PolygonToLine
            {
                in_features = inFeatureClassPath,
                out_feature_class = outputPath,
                neighbor_option = "IGNORE_NEIGHBORS"
            };
            //IDENTIFY_NEIGHBORS：识别面邻域关系。如果某个面的不同线段与不同的面共用边界，那么该边界将被分割成各个唯一公用的线段，这些线段的两个邻近面 FID 值将存储在输出中。
            //IGNORE_NEIGHBORS：忽略面邻域关系；每个面边界均将变为线要素，并且边界原始面要素ID将存储在输出中。 
            return (IGeoProcessorResult)Geoprocessor.Execute(polygonToLine, null);
        }
        /// <summary>
        /// 面转线
        /// </summary>
        /// <param name="inFeatureclass"></param>
        /// <param name="resultClassName"></param>
        /// <param name="saveNeighborInfo"></param>
        /// <returns></returns>
        [Obsolete("该方法暂未测试通过")]
        public IFeatureClass PolygonToPolyline(IFeatureClass inFeatureclass, string resultClassName, bool saveNeighborInfo)
        {
            var featureDataset = inFeatureclass.FeatureDataset;//要素数据集  
            var featuredatasetPath = featureDataset.Workspace.PathName + "\\" + featureDataset.Name + "\\";//要素数据集路径  

            PolygonToLine polygonToLine = new PolygonToLine
            {
                in_features = featuredatasetPath + inFeatureclass.AliasName,
                neighbor_option = saveNeighborInfo.ToString().ToLower(),
                out_feature_class = featuredatasetPath + resultClassName
            };
            Geoprocessor.Execute(polygonToLine, null);
            return (featureDataset.Workspace as IFeatureWorkspace)?.OpenFeatureClass(resultClassName); //获取生成的要素类  
        }
        /// <summary>
        /// 要素转线
        /// </summary>
        /// <param name="inFeatureClassPath"></param>
        /// <param name="outputPath"></param>
        [Obsolete("该方法暂未测试通过")]
        public void FeatureToPolyline(string inFeatureClassPath, string outputPath)
        {
            FeatureToLine featureToLine = new FeatureToLine(inFeatureClassPath, outputPath);
            Geoprocessor.Execute(featureToLine, null);
        }
        #endregion


        /// <summary>
        /// 调用裁剪工具，裁剪要素
        /// </summary>
        /// <param name="inFeatureClassPath">输入要素类的路径（eg:D:\xx.mdb\xx或D:\xx.shp）</param>
        /// <param name="clipFeatureClassPath">裁剪的要素类的路径（eg:D:\xx.mdb\xx或D:\xx.shp）</param>
        /// <param name="outFeatureClassPath">输出要素类的路径（eg:D:\xx.mdb\xx或D:\xx.shp）</param>
        /// <returns></returns>
        public IGeoProcessorResult Clip(string inFeatureClassPath, string clipFeatureClassPath, string outFeatureClassPath)
        {
            ESRI.ArcGIS.AnalysisTools.Clip clip = new ESRI.ArcGIS.AnalysisTools.Clip
            {
                in_features = inFeatureClassPath,
                clip_features = clipFeatureClassPath,
                out_feature_class = outFeatureClassPath
            };
            return (IGeoProcessorResult)Geoprocessor.Execute(clip, null);
        }
        /// <summary>
        /// 调用相交工具，将一个或多个图层的相交部分输出到指定路径中（注意输入要素类和叠加要素类不能有空几何等问题）
        /// </summary>
        /// <param name="inFeatureClassPaths">进行相交的一个或多个要素类路径，多个时用分号隔开，eg: @"F:\foshan\Data\wuqutu_b.shp;F:\foshan\Data\world30.shp"</param>
        /// <param name="outFeatureClassPath">输出要素类路径</param>
        /// <param name="joinAttributes">输入要素的哪些属性将传递到输出要素类：ALL, NO_FID, ONLY_FID</param>
        /// <returns></returns>
        public IGeoProcessorResult Intersect(string inFeatureClassPaths, string outFeatureClassPath, string joinAttributes = "ALL")
        {
            ESRI.ArcGIS.AnalysisTools.Intersect intersect = new ESRI.ArcGIS.AnalysisTools.Intersect
            {
                in_features = inFeatureClassPaths,
                out_feature_class = outFeatureClassPath,
                join_attributes = joinAttributes
            };
            return (IGeoProcessorResult)Geoprocessor.Execute(intersect, null);
        }
        /// <summary>
        /// 调用创建拓扑工具，创建拓扑
        /// </summary>
        /// <param name="topoFeatureDataset"></param>
        /// <param name="topoName"></param>
        /// <param name="tolerance"></param>
        /// <returns></returns>
        public ITopology CreateTopology(IFeatureDataset topoFeatureDataset, string topoName, double tolerance = 0.001)
        {
            CreateTopology createTopo = new CreateTopology
            {
                in_dataset = topoFeatureDataset,
                out_name = topoName,
                in_cluster_tolerance = tolerance
            };

            Geoprocessor.Execute(createTopo, null);
            ITopologyWorkspace topoWorkspace = topoFeatureDataset.Workspace as ITopologyWorkspace;
            return topoWorkspace.OpenTopology(topoName);
        }
        /// <summary>
        /// 调用要素类至要素类工具，即导出要素类至指定位置（指定位置中不能有同名要素类）
        /// </summary>
        /// <param name="inFeatureClass">输入要素类</param>
        /// <param name="whereClause">条件语句，根据条件语句筛选要素至新的要素类，可为null或Empty</param>
        /// <param name="outFeatureClassName">输出要素类名称</param>
        /// <param name="outDir">输出要素类的目录</param>
        public void FeautureClassToFeatureClass(IFeatureClass inFeatureClass, string whereClause, string outFeatureClassName, string outDir)
        {
            FeatureClassToFeatureClass featClstToFeatCls = new FeatureClassToFeatureClass
            {
                in_features = inFeatureClass,
                out_feature_class = outFeatureClassName,
                out_name = outFeatureClassName,
                out_path = outDir,
                where_clause = whereClause
            };
            Geoprocessor.Execute(featClstToFeatCls, null);
        }
    }
}
