# LeetCode题库的每日一题

3月份疫情以来，LeetCode为了方便我们这些又笨又懒的人，推出了每日一题的活动。每天不用想，只要到题库首页，点击置顶的那一条题目，开做吧。这个库就是我记录自己的解答的地方。

## 目录说明

每一个文件夹就是一道题。文件夹已题目编号为开头，双下划线'__'作为分隔符，后面跟上LeetCode中的题目名称。每一个文件夹内分为src和test。

src是.net core实现的题解。遵从LeetCode的命名规则，类为Solution，方法名根据每道题目不同而不同。

test是mstest写的unit test，用于测试。这里并没有注意测试方法的命名规范，因为每一个方法都很短，setup一眼就看明白了，所以方法命名上就没照顾到。

## 运行

都是class类工程，无法直接运行。通过在solution的根目录中执行 `dotnet test`运行测试例，来整体看一下结果。

```cmd.exe
D:\CODING\leetCodes>dotnet test
D:\CODING\leetCodes\1160__find-words-that-can-be-formed-by-characters\test\UnitTestProject\bin\Debug\netcoreapp3.1\UnitTestProject.dll 的测试运行(.NETCoreApp,Version=v3.1)
D:\CODING\leetCodes\compress-string-lcci\test\compress-string-lcci-test\bin\Debug\netcoreapp3.1\compress-string-lcci-test.dll 的测试运行(.NETCoreApp,Version=v3.1)
Microsoft (R) Test Execution Command Line Tool Version 16.3.0Microsoft (R) Test Execution Command Line Tool Version 16.3.0

Copyright (c) Microsoft Corporation.  All rights reserved.Copyright (c) Microsoft Corporation.  All rights reserved.



Starting test execution, please wait...
Starting test execution, please wait...

A total of 1 test files matched the specified pattern.

A total of 1 test files matched the specified pattern.
Test Run Successful.

Total tests: 3
     Passed: 3
Test Run Successful.
Total tests: 5
 Total time: 1.3017 Seconds
     Passed: 5
 Total time: 1.2958 Seconds
```

## 测试覆盖率

通过 [coverlet](https://github.com/coverlet-coverage/coverlet/blob/master/Documentation/MSBuildIntegration.md) NugetPackage 来统计测试覆盖率。  
步骤：  
1. 全部**测试项目**中添加两个nuget 包：coverlet.msbuild 和 coverlet.collector  
1. 执行 `dotnet test /p:CollectCoverage=true`  
1. 可选添加 CoverletOutputFormat=opencover，将输出格式变为opencover，以上传[coveralls.io](https://coveralls.io/github/chengwhynot/leetCodes)。`dotnet test /p:CollectCoverage=true /p:CoverletOutputFormat=opencover`  

输出如下：  

> Passed!  - Failed:     0, Passed:     4, Skipped:     0, Total:     4, Duration: 46 ms - remove-duplicates-test.dll (netcoreapp3.1)
> 
> Calculating coverage result...
>   Generating report 'D:\CODING\leetCodes\x2gy9m__remove-duplicates\test\remove-duplicates-test\coverage.json'
> 
> +-------------------+------+--------+--------+
> | Module            | Line | Branch | Method |
> +-------------------+------+--------+--------+
> | remove-duplicates | 100% | 100%   | 100%   |
> +-------------------+------+--------+--------+
> 
> +---------+------+--------+--------+
> |         | Line | Branch | Method |
> +---------+------+--------+--------+
> | Total   | 100% | 100%   | 100%   |
> +---------+------+--------+--------+
> | Average | 100% | 100%   | 100%   |
> +---------+------+--------+--------+
> 

别忘了写测试！
