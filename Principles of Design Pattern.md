# 设计模式的7大原则

## 1. 依赖倒置原则

```
MyTest myTest = new MyTest(); // 硬编码

// 依赖于抽象，依赖于接口
IMyTest myTest = new MyTest(); 
```

## 2. 单一职责

只做一件事情，不会做其他不相关，或者跨界的事情...



```
public class User {
	Add();
	Modify();
	// AddOrder();
}

public class Order() {

}
```

专业的人做专业的事情...

## 3. 开闭原则

 开：可以添加，新增代码

 闭：对修改代码

我们做新功能，不希望对于原有的代码进行修改... 【通俗易懂】

## 4. 合成复用原则

我们给一个类添加功能：【继承】【关联】

继承：子类可以获取父类的状态和行为。（非private）

关联：

```
Order order = new Order();
order.user...

public class Order {
	public User user = new User();
}

public class User {

}
// 继承
public class User: Order { 
	// 获取Order的行为或状态
}
```

1. **is-a** 情况下使用继承

2. **has-a** 情况下使用聚合 【桥接模式】

## 5. 迪米特法则（最少知道原则【Demeter Principle】）

类与类之间保持相互独立，这样才能降低耦合... 类与类之间避免不了相互通信的问题

A   <-->  B

我绝不希望在A中引用B，在B中引用A...         引入**中间件 ** 【Redis、RabbitMQ】

## 6. 接口隔离原则

将几个类中的方法都提取到一个接口中，形成一个大接口... 然后让子类去继承这个大接口【错】

子类只需要继承自己需要的接口【最少化接口】

Orders【订单系统】

前台站点：Query

网站后台：CRUD

第三方分销商：Query，Add

```
// 不可取
public interface IOrder() {
	Add();
	Modify();
	Query();
	Remove();
}

public interface IOrder1() {
	Add();
}

public interface IOrder2() {
	Add();
	Query();
}

public interface IOrder3() {
	Add();
	Modify();
	Query();
	Remove();
}
```







## 7. 里氏替换原则

父类存在的地方，子类都可以替换，并且行为不发生改变...

1. 人类可以上厕所（Action）

   ```
         人类
   
   男人       女人
   ```
   
2. 鸟（Fly）Action

   燕子（Fly） 企鹅（Fly）

   违反了“里氏替换原则”

   生物学上分类不见得在面向对象中行的通 【特例】