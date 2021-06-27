# ReadAndWriteSharp

### 介绍
使用C#，基于 .NET Framework 的文件读写类库。<br>
是使用C#对[ReadAndWriteJ](https://gitee.com/swsk33/ReadAndWriteJ)的实现。<br>

### 使用方法
下载发行版中dll文件，在vs2019中项目-引用里面添加即可。<br>
或者在nuget包管理中搜索ReadAndWriteSharp下载。<br>
然后使用下列语句添加命名空间：<br>
```
using Swsk33.ReadAndWriteSharp.Param;
using Swsk33.ReadAndWriteSharp.Model;
using Swsk33.ReadAndWriteSharp;
```

### 公用类及其方法
位于命名空间*Swsk33.ReadAndWriteSharp*下：<br>
#### TextUtils：文本处理实用类
- static string SurroundBySingleQuotes(string origin)：使用单引号包围字符串
- static string SurroundByDoubleQuotes(string origin)：使用双引号包围字符串
- static string EscapeCharacterInString(string origin)：将原字符串中特殊字符转义存储（暂不支持Unicode）
#### TextFileReader: 文本文件读取器
- static int GetFileLine(string filePath)：读取文本文件的行数
- static string ReadSpecificLine(string filePath, int line)：读取文本文件指定行
- static string ReadSpecificLine(string filePath, int line, Encoding encoding)：使用特定的编码读取文本文档指定行
- static string ReadSpecificRange(string filePath, int start, int end)：读取指定行数范围内的内容并以字符串形式储存，包含起始行和终止行
- static string ReadSpecificRange(string filePath, int start, int end, Encoding encoding)：以指定的编码读取指定行数范围内的内容并以字符串形式储存，包含起始行和终止行
#### TextFileWriter: 文本文件写入器
- static bool ReplaceSpecificLine(String filePath, string content, int line)：用指定内容替换文件指定行
- static bool ReplaceSpecificLine(String filePath, string content, int line, Encoding encoding)：使用指定的字符编码，用指定内容替换文件指定行
- static bool AppendText(string filePath, string content)：向文本文件末尾追加文本
- static bool AppendText(string filePath, string content, Encoding encoding)：使用指定的字符编码，向文本文件末尾追加文本
- static bool InsertText(string filePath, string content, int line)：在指定行之后插入一行指定文本
- static bool InsertText(string filePath, string content, int line, Encoding encoding)：使用指定字符编码，在指定行之后插入一行指定文本
- static bool RemoveSpecificLine(string filePath, int line)：移除文件指定行内容
- static bool ClearAll(string filePath)：将指定文件内容清空
#### BinaryUtils: 二进制文件工具类
- static byte[] ReadBinaryFile(string filePath)：读取二进制文件为字节数组
- static bool WriteBinaryFile(string filePath, byte[] content)：将二进制数据写入指定文件，文件不存在将创建，存在将被覆盖
- static bool WriteObjectToFile<T>(string filePath, T data)：将可序列化的对象写入文件，文件不存在将创建，存在将被覆盖
- static T ReadObjectFromFile<T>(string filePath)：从文件中读取数据并反序列化为相应的对象
- static void GetDirectoryInfo(string dirPath, DirInfo info)：获取文件夹信息并储存在一个DirInfo实例中
- static void CopyDir(string origin, string dest)：复制文件夹
- static bool ExtractNormalFileInResx(byte[] resource, string path)：释放嵌入在resx里面的普通类型文件
- static bool ExtractAudioFileInResx(Stream fileInResx, string path)：释放嵌入在resx文件里面的音频资源文件
- static bool ExtractImageFileInResx(Bitmap image, string path)：释放嵌入在resx里的图片资源文件
- static bool ExtractTextFileInResx(string textFile, string path)：释放嵌入在resx中的文本文件
- static string GetFileFormat(string filePath)：获取文件扩展名，不带.
- static string GetFileMD5(string filePath)：获取文件MD5值
- static string GetFileSHA1(string filePath)：获取文件SHA1值
#### TerminalUtils:终端实用类
- static string[] RunCommand(string command, string args)：调用命令行并获取执行结果，该方法为同步方法，会堵塞线程
- static string[] RunCommand(string command, string[] args)：调用命令行并获取执行结果，该方法为同步方法，会堵塞线程
- static void RunCommandAsynchronously(string command, string args, TerminalResult result)：异步执行命令行并将输出结果实时储存在一个TerminalResult类型的实例中
- static void RunCommandAsynchronously(string command, string[] args, TerminalResult result)：异步执行命令行并将输出结果实时储存在一个TerminalResult类型的实例中
#### NetworkUtils：网络实用类
- static string SendGetRequest(string url)：发送GET请求
- static string SendGetRequest(string url, string userAgent)：发送自定义UserAgent的GET请求
- static string SendGetRequest(string url, Dictionary<string, string> headers)：发送自定义请求头的GET请求
- static string SendPostRequest(string url, string contentType, string requestBody)：发送POST请求
- static string SendPostRequest(string url, string userAgent, string contentType, string requestBody)：发送自定义UserAgent的POST请求
- static string SendPostRequest(string url, Dictionary<string, string> headers, string requestBody)：发送自定义请求头的POST请求
- static bool DownloadFile(string url, string filePath)：下载文件
- static bool DownloadFile(string url, string userAgent, string filePath)：以一个特定的UserAgent下载文件
- static bool DownloadFile(string url, Dictionary<string, string> headers, string filePath)：以一个自定义的请求头下载文件
#### RegUtils：注册表实用类
- static bool IsItemExists(RegistryKey mainKey, string itemName)：判断注册表项是否存在
- static bool IsValueExists(RegistryKey mainKey, string itemName, string valueName)：判断注册表某一项的某个值是否存在
- static bool OperateBootOption(string name, string exec, bool isAddOption)：添加/移除开机启动项
- static bool OperateFileOrDirRightMenu(string name, string exec, bool isAddOption)：添加/移除文件或者文件夹右键菜单
- static bool OperateFileOrDirRightMenu(string name, string iconPath, string exec, bool isAddOption)：添加/移除文件或者文件夹右键菜单，且在添加操作时指定其图标
- static bool OperateDirectoryBackgroundMenu(string name, string exec, bool isAddOption)：添加/移除文件夹背景/桌面右键菜单
- static bool OperateDirectoryBackgroundMenu(string name, string iconPath, string exec, bool isAddOption)：添加/移除文件夹背景/桌面右键菜单，且在添加操作时指定其图标
- static bool OperateAppUninstallItem(AppUninstallInfo appInfo, bool isAddOption)：添加/删除应用程序卸载信息条目

**在vs中使用这些类即可显示其中详细的的方法与说明，前提是引用类库时必须将下载的dll和xml文件放一起，或者直接使用nuget包**<br>

>最后更新：2021.6.21