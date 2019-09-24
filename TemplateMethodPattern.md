# 模板方法模式

## 1. 试卷

​    （1）今天暖和吗？（）

​               A：是    B：否

- 张三：A
- 李四：B

模板方法：

> 定义了一个算法骨架，将可变的部分延迟到了子类...
>
> 封装不可变的，将可变的部分延迟到子类...
>
> 一种多态的实现



## 2. 真实项目

简单工厂 + 模板模式



事件：0、1、96、97、98

根据事件模型  => 判断是否今天可以触发  => 获取人数（分：顾问创建、非顾问创建）

​        0：顾问创建

​        96、97：顾问创建

【全量跑用户】【增量跑用户】

1. 获取人数的方法不可变：GetCustomerList

   ```
   public override List<MarketCustomerModel> GetCustomerList(LeafletEntity leaflet, DataRow row) {
       this.IsAdvisercreateEvent = false;
       return base.GetCustomerList(leaflet, row);
   }
   ```

   

```
public abstract AbstractEventPattern {
	// 获取客户数
    public virtual List<MarketCustomerModel> GetCustomerList(LeafletEntity leaflet, DataRow row) {
        var marketingCustomerList = jobMarketHelper.GetMarketingCustomerByEventQuery(leaflet.ShopID,
        	MySqlHelper.GetString(row, "analyzecondition"),
            IsAdvisercreateEvent,
            leaflet.CommunicationtypeEnum
        ) ?? new List<MarketCustomerModel>();
        return marketingCustomerList;
	} 
	public virtual bool IsAdvisercreateEvent { get; set; };
}

```



