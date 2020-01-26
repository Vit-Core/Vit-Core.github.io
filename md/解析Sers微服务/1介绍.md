# Sers微服务架构协议
Sers为一套跨平台跨语言的开源微服务架构协议。

net core版本（2.1.1）单机QPS能达15万。
目前支持C++、Java、c#、javascript。

 

 

# 性能数据 

>qps数据来源于 ab 和 ApiStationMng.html 页面中的统计

项目部署在同一机器, Robot和StationDemo都附加在ServiceCenter上
   
| Os  |  robot内部调用(8线程)   |  ab压测(32线程，CGateway)   |
| ------------ | ------------ | ------------ |
| Windows10 |  150000 | |
| CentOs7(2核1G) |15000|3500|
| CentOs7(4核1G) |25000|5000|
 
 