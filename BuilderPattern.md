# 建造者模式

## 1. 建造者模式

房子：可划分为【单元楼、别墅】

组成部分：【沙石、水泥、钢筋、砖】

沙石的品牌：【多变】



一个复杂的对象由很多的子部件组成，子部件是多变的，但是子部件的组成流程却是不易变的



```
class 单元楼 {
	沙石、水泥、钢筋、砖
}
class 别墅 {
	沙石、水泥、钢筋、砖
}
```

## 2. 大话设计模式【人的构建】

人：可划分为【胖人，瘦人】

```
class Person {
	头、身体、手、脚
}
```

部件是多变的，组合在一起是不易变的

## 3. 真实案例

彩信运营商：【助通、联合维拓】

```
// AbstractMMS
class AbstractMMS {
	createProductName
	createProductLink
	createTaoCommand
	createSign
}
// ZhuTongMMS
class ZhuTongMMS {
	createProductName
	createProductLink
	createTaoCommand
	createSign
}
// LianHeWeiTuoMMS
class LianHeWeiTuoMMS {
	createProductName
	createProductLink
	createTaoCommand
	createSign
}
class BuilderDirector {
	// ...
}
```



**彩信的模板**

> 标题：玛丽黛佳旗舰店 给您送礼啦
>
> 第一贞：
>
> ​	图片：推荐商品图，第3张
>
> ​	打开手机淘宝，淘口令（）
>
> ​	更多惊喜，更多推荐（链接）
>
> 第二贞：
>
> ​	图片：推荐商品图，第2张
>
> ​	打开手机淘宝，淘口令（）
>
> ​	更多惊喜，更多推荐（链接）
>
> 第三贞：
>
> ​	图片：推荐商品图，第1张
>
> ​	打开手机淘宝，淘口令（）
>
> ​	更多惊喜，更多推荐（链接）
>
> 【玛丽黛佳旗舰店】回复TD退订