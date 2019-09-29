# 工厂方法模式
## 一、简单工厂模式（Simple Factory Pattern）
### 1. 简单工厂

创建型的设计模式

工厂里面：将类的创建放在一个工厂里面，屏蔽了客户端和创建逻辑

SqlServer 太浪费资源了，我需要换成小型的SqlLite

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



### 2. 总结

**优点**

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

**缺点**

​    开闭原则，因为需要修改代码... 【不讲究绝对】

### 3. 真实项目

​    事件式营销

​     0号：

​	 1号：

​	 96号：

​	 97号：1号、15号执行

 	98号：每周的周一执行





## 二、工厂方法

模式： 都有优缺点

工厂  并不一定比 简单工厂 更好

【开闭原则】

简单工厂模式下，我增加了一个MongodbUser，我需要改动的地方

	1. 修改Factory
 	2. 新增一个类



简单工厂最大的好处：用一个字符串代替了一个类的实例化

简单工厂和工厂

1. 工厂解决了简单工厂中Factory的switch-case问题
2. 工厂将选择给了Client端... 比如我想使用Mongodb，就必须先new一个MogodbFactory...



## 三、抽象工厂

比如IUser是db中的一张表，但是db中有很多表...

比如说现在新增一张Order表...

