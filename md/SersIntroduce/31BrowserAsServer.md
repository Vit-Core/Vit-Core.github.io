# ���������������
  һ�㣬�������Ϊ�ͻ��ˣ����ķ�����ṩ�ķ��񡣵�����԰�ʳ����������һ�±���Ҫ�ĸо�.����������㡢��ͨ�ţ���ô���Ϳ��԰��Լ����������������ṩ����һ�ѷ���˵�񫡣

����������һ��һ���������ʵ���Լ������롣


## 1.docker
### 1.1 �����������
>docker����������ĺܼ򵥣�һ������㶨

```shell
docker run --name=sers_servicecenter --net=host -d sersms/sers_dotnet_servicecenter:2.1.1.250
```

�����㣬�������ľͲ�����ˣ����Ὺ��4580�˿���Ϊ������ڣ�����4503�˿���Ϊwebsocket����ͨ�Ŷ˿ڡ�
������������򿪵�ַ <http://ip:4580/_gover_/index.html?user=admin_123456> ��������������̨��������ʱ�ò������

### 1.2 JsStation�ǳ�
>�������Ĳ�����ˣ���������������������ˡ�

�򿪵�ַ <http://ip:4580/JsStation/JsStation.html> ����JsStation����վ��ҳ�档
�ֱ���������api����ť�͡��������񡱰�ť������ť�Ϸ��ı�������������������Ѿ���Ϊ����վ���ṩ�����ˡ�

```javascript
[17:16.482][info]����api...
[17:16.485][info]api�Ѽ��أ�������1
[17:17.821][info][sers.CL]try connect...
[17:17.957][info][ServiceStation] regist serviceStation to ServiceCenter...
[17:17.980][info][ServiceStation] regist - succeed
```
 ��������֤һ��������Ƿ�����ṩ�˷���������½����ڣ��򿪵�ַ <http://ip:4580/JsStation/api1?a=1>,���з������ݣ���ť�Ϸ��ı���������Ϣ��˵������������Ϊ������ṩ�����ˡ����Ǽ�֤������������������ˡ�
 
���ǿ�һ�°�ť�·��ı�������ݡ� 
```javascript
[
{
    route: '/JsStation/api1', httpMethod: 'GET', apiName: 'js��Ϊ����վ��',
    onInvoke: function (requestData_bytes, rpcData, reply_rpcData) {
        var request_string = vit.bytesToString(requestData_bytes);
        vit.logger.info('[api����] request:' + request_string );
        var replyData = {
            success: true,
            data:
            {
                request_string: request_string,
                _: Math.random()
            }
        };
        return vit.objectSerializeToBytes(replyData);
    }
}

]

```
route��������ַΪhttp://ip:4580/JsStation/api1�� onInvoke�ص�����ָ�����񱻵���ʱ�������������ǿ����Լ��޸�һ�»ص����ֱ���������api����ť�͡��������񡱰�ť���ٴ򿪵�ַ <http://ip:4580/JsStation/api1?a=1>,��֤һ���ǲ����������Լ��������԰ɡ�


## 2.windows
�������windows�����У�����ֱ�����ط������ĳ���Ȼ�����С�
### 2.1���س����ļ�
�� <http://sersms.github.io/file/Sers/Sers2.1.1.250.zip> ���س����ļ���
### 2.2���з�������
��ѹ�����ص�ѹ���ļ���˫����ѹ���ļ����е��ļ���01 ServiceCenter.bat���������з�������
>������������net core��д�ģ����Ȱ�װnet core 2.1���л�����


