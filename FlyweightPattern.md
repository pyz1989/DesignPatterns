# 享元模式

## 01. 共享元数据的意思 ？

减少内存开销，避免在内存中实例化众多相识或相同的实例

1. 做了十次new，其实都是一个类，如果我们把这个new缓存起来，下次new的时候还是取这个缓存...   

   【节省了内存】

2. C# GC

## 02. .Net中有很多这样的案例

string的驻留池

Redis、DB的连接池

线程池   而不是每次都是new Thread() ...

Task => 寄托在线程池上的 线程，而且是多包装的

## 03. Razor 【Asp.Net MVC 模板引擎】

https://github.com/Antaris/RazorEngine

```
string template = "Hello @Model.Name, welcome to RazorEngine!";
var result = Razor.Parse(template, new { Name = "World" });
```



Razor：模板 + 商品 => 一封邮件

```
// RazorEngine, Version=3.10.0.0, Culture=neutral, PublicKeyToken=9ee697374c7e744a
// RazorEngine.Templating.TemplateService
using System;
/// <summary>
/// Gets an instance of the template using the cached compiled type, or compiles the template type
/// if it does not exist in the cache.
/// </summary>
/// <typeparam name="T">The model type.</typeparam>
/// <param name="razorTemplate">The string template.</param>
/// <param name="model">The model instance.</param>
/// <param name="name">The name of the template type in the cache.</param>
/// <returns>An instance of <see cref="T:RazorEngine.Templating.ITemplate`1" />.</returns>
public virtual ITemplate GetTemplate<T>(string razorTemplate, object model, string name)
{
	if (razorTemplate == null)
	{
		throw new ArgumentNullException("razorTemplate");
	}
	ITemplateKey keyAndAdd = GetKeyAndAdd(razorTemplate, name);
	model = CheckModel(model).Item1;
	return _service.GetTemplate(keyAndAdd, typeof(T), model, null);
}

```

模型

可变和不可变参数