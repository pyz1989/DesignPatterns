# 装饰者模式

## 1. 装饰者模式

### 01.装饰 => 装修

给一个对象添加额外的行为

### 02. 买手机

贴膜、挂件、手机壳  => 手机的装饰

### 03.买房子

砸墙、砌墙、腻子

装饰的形式是变化的 ... 对一些装饰子类按照聚合的形式组合在一起，而不是用继承的方式 ...

桥接模式  【组合优于继承  （has-a，is-a）】

## 2. 手机【装饰者模式】

1. Component： 抽象手机类                    =>  Phone
2. ConcreteComponent：具体的手机    =>  ApplePhone
3. Decorate：装饰的抽象类
4. Sticker [Decorate]：贴膜   =>  给ApplePhone贴膜
5. Accessories ：配件             =>  给ApplePhone进行配件

## 03. C#中有没有装饰者模式

MemoryStream、GzipStream、FileStream、CryptoStream

比如有一串字符串数组【byte[]】 -> 内存流