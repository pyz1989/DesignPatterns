## 迭代器模式

> 用来遍历集合的...    foreach (C#、Java)

foreach 一个集合，底层到底做了什么？

foreach就是迭代器...    【语法糖】

```
List<int> intList = new List<int>() { 0, 1, 2, 3, 4, 5, 6 };
foreach (var item in intList)
{
	Console.WriteLine(item);
}
```



```
	.try
	{
		IL_0047: br.s IL_005a
		// loop start (head: IL_005a)
			IL_0049: ldloca.s 1
			IL_004b: call instance !0 valuetype [System.Collections]System.Collections.Generic.List`1/Enumerator<int32>::get_Current()
			IL_0050: stloc.2
			IL_0051: nop
			IL_0052: ldloc.2
			IL_0053: call void [System.Console]System.Console::WriteLine(int32)
			IL_0058: nop
			IL_0059: nop

			IL_005a: ldloca.s 1
			IL_005c: call instance bool valuetype [System.Collections]System.Collections.Generic.List`1/Enumerator<int32>::MoveNext()
			IL_0061: brtrue.s IL_0049
		// end loop

		IL_0063: leave.s IL_0074
	} // end .try
	finally
	{
		IL_0065: ldloca.s 1
		IL_0067: constrained. valuetype [System.Collections]System.Collections.Generic.List`1/Enumerator<int32>
		IL_006d: callvirt instance void [System.Runtime]System.IDisposable::Dispose()
		IL_0072: nop
		IL_0073: endfinally
	} // end handler
```

Enumerator: 迭代类

迭代类的好处：

1. 读写分离

2. 封装了元数据，比如底层的Array数组

3. 简化的业务逻辑

   List中foreach和for都可以循环

   ```
   public class List<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IList, ICollection, IReadOnlyList<T>, IReadOnlyCollection<T>
   {
   	private T[] _items;
   }
   
   for (int i = 0; i < intList.Count; i++)
   {
   	Console.WriteLine(intList[i]);
   }
   ```

   HashSet

   如果你说for和foreach是一样的，你能用for循环HashSet吗？

   ```
   // HashSet
   internal struct Slot
   {
   	internal int hashCode;
   	internal int next;
   	internal T value;
   }
   private Slot[] m_slots;
   
   [__DynamicallyInvokable]
   public bool MoveNext()
   {
   	if (version != set.m_version)
   	{
   		throw new InvalidOperationException(System.SR.GetString("InvalidOperation_EnumFailedVersion"));
   	}
   	while (index < set.m_lastIndex)
   	{
   		if (set.m_slots[index].hashCode >= 0)
   		{
   			current = set.m_slots[index].value;
   			index++;
   			return true;
   		}
   		index++;
   	}
   	index = set.m_lastIndex + 1;
   	current = default(T);
   	return false;
   }
   ```

   HashSet：主要是一个哈希算法

   Array

注意事项：

​	一个聚合对象，一个枚举类