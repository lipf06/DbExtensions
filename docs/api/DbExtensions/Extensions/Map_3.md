Extensions.Map Method (IDbCommand, Type, TextWriter)
====================================================
Maps the results of the *command* to objects of type specified by the *resultType* parameter. The query is deferred-executed.

**Namespace:** [DbExtensions][1]  
**Assembly:** DbExtensions (in DbExtensions.dll)

Syntax
------

```csharp
public static IEnumerable<Object> Map(
	this IDbCommand command,
	Type resultType,
	TextWriter logger
)
```

#### Parameters

##### *command*
Type: [System.Data.IDbCommand][2]  
The query command.

##### *resultType*
Type: [System.Type][3]  
The type of objects to map the results to.

##### *logger*
Type: [System.IO.TextWriter][4]  
A [TextWriter][4] used to log when the command is executed.

#### Return Value
Type: [IEnumerable][5]&lt;[Object][6]>  
The results of the query as objects of type specified by the *resultType* parameter.
#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [IDbCommand][2]. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][7] or [Extension Methods (C# Programming Guide)][8].

See Also
--------

#### Reference
[Extensions Class][9]  
[DbExtensions Namespace][1]  

[1]: ../README.md
[2]: http://msdn.microsoft.com/en-us/library/bt2afddc
[3]: http://msdn.microsoft.com/en-us/library/42892f65
[4]: http://msdn.microsoft.com/en-us/library/ywxh2328
[5]: http://msdn.microsoft.com/en-us/library/9eekhta0
[6]: http://msdn.microsoft.com/en-us/library/e5kfa45b
[7]: http://msdn.microsoft.com/en-us/library/bb384936.aspx
[8]: http://msdn.microsoft.com/en-us/library/bb383977.aspx
[9]: README.md