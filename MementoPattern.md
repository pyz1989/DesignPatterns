# 备忘录模式

## 1. 备忘录模式

### 01. 定义

>  记录某一对象在某一时刻的状态...  在合适的时候进行恢复
>
>  可以撤销，可以恢复

### 02. 举个例子

Ctrl + Z、PhotoShop 回退功能、悔棋    【后悔】

## 2. 真实项目

### 1. leaflet 

 【营销活动】 100个

```
public class Leaflet {
	customerList
	发送时间
	发送渠道
}
```

首先，通过 customerID 获取到一批人。

然后，对这100个leaflet进行过滤

【集合过滤】所有的leaflet中 customerID 是唯一的

【疲劳度过滤】3天之内不发送

```
leaflet1: 100 -> 80
leaflet2: 50 -> 40
leaflet3: 120 -> 90
```

leaflet3建错了，我要恢复，我要删除leaflet3，是不是leaflet1和leaflet2的人给恢复处理？？？

## 3. 备忘录模式的原型

1. 发起者： Originator        需要备份的实体

2. 备忘实体：Memento       需要将状态保存到该对象的实体

3. 看门人：CareTaker          管理这个Memento

## 4. 这个道理就是 该模式 和Clone模式的区别

只保存部分状态


