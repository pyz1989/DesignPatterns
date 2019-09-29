# 观察者模式

## 1. 中间件

1. Redis发布订阅
2. RabbitMQ fanout模式 分发一种机制

## 2. MVVM模式的JS框架

MVVM模式	本质就是 观察者模式 [Knockout](https://knockoutjs.com/)【JS框架】 

## 3. 一睹为快

```
              subject
observer1    observer2    observer3
```

协调观察者的一致性

1. 轮询，如果发现subject被修改，observer进行自我更新。【资源浪费、延迟性（1 s）】
2. 主动的推送，如果subject被修改，subject会主动向三个observer进行推送通知...

​                               然后，observer就可以自我更新

​                                                                                                          【没有浪费、及时性】

## 4. 代码

## 5. MVVM模式的依赖跟踪特性分析

1. 主题：this.firstName、this.lastName、this.fullName
2. 鼠标离开，有一个blur事件，这个事件会修改firstName的值，当firstName被修改，触发notify函数，这个时候fullName会收到通知，最终值会被修改...

```
// Source code: View
<p>First name: <input data-bind="value: firstName" /></p>
<p>Last name: <input data-bind="value: lastName" /></p>
<h2>Hello, <span data-bind="text: fullName"> </span>!</h2>

// Source code: View model
// Here's my data model
var ViewModel = function(first, last) {
    this.firstName = ko.observable(first);
    this.lastName = ko.observable(last);
 
    this.fullName = ko.pureComputed(function() {
        // Knockout tracks dependencies automatically. It knows that fullName depends on firstName and lastName, because these get called when evaluating fullName.
        return this.firstName() + " " + this.lastName();
    }, this);
};
 
ko.applyBindings(new ViewModel("Planet", "Earth")); // This makes Knockout get to work
```

