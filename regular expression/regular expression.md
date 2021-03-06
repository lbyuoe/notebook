# 普通字符
- [ABC]：匹配[]中所有字符
- [^ABC]：匹配除了[]中的所有字符
- [A-Z]：表示一个区间，匹配所有大写字母
- .：匹配除换行符之外的所有字符，相当于[^\n\r] 
- [\s]：匹配所有空白符，相当于[\f\n\r\t\v]
- [\S]：匹配所有非空白符
- [\w]：匹配字母、数字、下划线，等于[a-zA-Z0-9_]

# 非打印字符
- [\cx]：匹配由x指明的控制字符。
- [\f]：匹配一个换页符。
- [\n]：匹配一个换行符
- [\r]：匹配一个回车符
- [\t]：匹配一个制表符
- [\v]：匹配一个垂直制表符

# 特殊字符
匹配特殊字符时需要先使字符转义，即将反斜杠\放在他们前面
- $：匹配输出字符的结尾位置
- ^：匹配输出字符的开始位置。如果在方括号表达式中使用，表示不接受该方括号表达式中的字符集合
- [：标记一个中括号表达式的开始，定义匹配的字符范围
- {：标记限定符表达式的开始，表示匹配的长度
- |：指明两项之间的一个选择

# 限定符
- *：匹配前面的子表达式任意次数
- +：匹配前面的子表达式至少一次
- ?：匹配前面的子表达式至多一次
- {n}：匹配确定的n次
- {n, }：至少匹配n次
- {n, m}：n<=m，最少匹配n次且最多匹配m次

## 贪婪和非贪婪
当正则表达式中包含能接受重复的限定符时，通常的行为是匹配尽可能多的字符（+、*）。  
有时需要非贪婪匹配（懒惰匹配），也就是匹配尽可能少的字符，只要在*、+、?限定符之后放置?。

# 定位符
- ^：匹配输入字符串开始的位置
- $：匹配输入字符串结尾的位置
- \b：匹配一个单词边界，即字与空格间的位置
- \B：非单词边界匹配

不能将限定符与定位符一起使用。

# 选择
- ()：提取匹配的字符串，相邻的选择项之间用|分隔。

()会捕获分组，()会把每个分组里的匹配的值保存起来，多个匹配值可以通过数字n来查看。  
但用()会有一个副作用，使相关的匹配会被缓存。

# 非捕获元
- (?:pattern)：匹配pattern但不获取匹配结果，是非获取匹配，不进行存储供以后使用。
- (?=pattern)：正向肯定预查，在任何匹配pattern的字符串开始处匹配查找字符串。是非获取匹配。
- (?!pattern)：正向否定预查，在任何不匹配pattern的字符串开始处匹配查找字符串。
- (?<=pattern)：反向肯定预查，与正向肯定预查类似，只是方向相反。
- (?<!pattern)：反向否定预查，与正向肯定预查类似，只是方向相反。

# 反向引用
对一个正则表达式模式或部分模式两边添加圆括号将导致相关匹配存储到一个临时缓冲区中，所捕获的每个子匹配都按照在正则表达式模式中从左到右出现的顺序存储。缓冲区编号从1开始，最多可存储99个捕获的子表达式。每个缓冲区都可以使用\n访问，其中n为一个标识特定缓冲区的一位或两位十进制数。  
可以使用非捕获元字符 ?:、?= 或 ?! 来重写捕获，忽略对相关匹配的保存。