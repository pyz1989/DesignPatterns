# 简单工厂模式

简单工厂模式

创建型的设计模式

工厂里面：将类的创建放在一个工厂里面，屏蔽了客户端和创建逻辑

​                SqlServer 太浪费资源了，我需要换成小型的SqlLite

普通方式：

```
 Database db1 = new SqlLite();
 Database db2 = new SqlLite();
 Database db3 = new SqlLite();
 Database db4 = new SqlLite();
```

如果修改数据库，我们需要改变4次实例化...   违背【开闭原则】

```
public class Person {
	private int age;
	public int Age {
		get {
			return age;
		}
	}
}
```



## 2. 总结

###     优点

   1. 方便切换DB...  原理在于用 “string” 来代替 “new” 的硬编码

      string 可以存放DB，Config

   2.  放到一起管理，可以省略一些new的时候的构造函数

      ```
      return new SqlServer() {
      	Connection = "",
      	Port = 1433,
      	//...
      }
      ```

      

   3.  屏蔽了创建逻辑... 将创建的逻辑从客户端中屏蔽开，专门由一个团队去处理...

###     缺点

​    开闭原则，因为需要修改代码... 【不讲究绝对】

## 3. 真实项目

​    事件式营销

​     0号：

​	 1号：

​	 96号：

​	 97号：1号、15号执行

 	98号：每周的周一执行