# 命令模式

## 1. 思想
```
    将行为的请求者和请求的实现者进行分离
    
    public class SqlServerHelper
    {
    	public void Add() {
    		// 实现
    	}
    	public void Remove() {
    		// 实现
    	}
    }
    
    SqlServerHelper sqlHelper = new SqlServerHelper();
    sqlHelper.Add();
```

  Winform 经常有撤销...    【撤销命令，恢复状态】



  命令模式：有3个角色（Received、Command 、Invoker ）

1. Received    最终要执行的命令

2. ICommand    将Received命令的方法进行抽象，抽象成一个**Execute**方法

3. ConcreteCommand    将Received中的每一个命令生成每一个具体的子类...    

   ​    Add()          =>     AddCommond; 

   ​    Remove()    =>   RemoveCommond 

4. Invoker    命令调用:给Client进行调用，同时这个类要实现命令的执行、恢复、撤销等操作

5. Client    

