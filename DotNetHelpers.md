<a name='assembly'></a>
# DotNetHelpers

## Contents

- [Dropdown\`1](#T-DotNetHelpers-Models-Dropdown`1 'DotNetHelpers.Models.Dropdown`1')
  - [#ctor()](#M-DotNetHelpers-Models-Dropdown`1-#ctor 'DotNetHelpers.Models.Dropdown`1.#ctor')
  - [#ctor(value,text)](#M-DotNetHelpers-Models-Dropdown`1-#ctor-`0,System-String- 'DotNetHelpers.Models.Dropdown`1.#ctor(`0,System.String)')
  - [Selected](#P-DotNetHelpers-Models-Dropdown`1-Selected 'DotNetHelpers.Models.Dropdown`1.Selected')
  - [Text](#P-DotNetHelpers-Models-Dropdown`1-Text 'DotNetHelpers.Models.Dropdown`1.Text')
  - [Value](#P-DotNetHelpers-Models-Dropdown`1-Value 'DotNetHelpers.Models.Dropdown`1.Value')
- [EnumExtentions](#T-DotNetHelpers-Extentions-EnumExtentions 'DotNetHelpers.Extentions.EnumExtentions')
  - [GetDisplayName(value)](#M-DotNetHelpers-Extentions-EnumExtentions-GetDisplayName-System-Enum- 'DotNetHelpers.Extentions.EnumExtentions.GetDisplayName(System.Enum)')
  - [ToCollection\`\`1()](#M-DotNetHelpers-Extentions-EnumExtentions-ToCollection``1-System-Type- 'DotNetHelpers.Extentions.EnumExtentions.ToCollection``1(System.Type)')
- [EnumerableExtensions](#T-DotNetHelpers-Extentions-EnumerableExtensions 'DotNetHelpers.Extentions.EnumerableExtensions')
  - [Join\`\`1(source,separator)](#M-DotNetHelpers-Extentions-EnumerableExtensions-Join``1-System-Collections-Generic-IEnumerable{``0},System-String- 'DotNetHelpers.Extentions.EnumerableExtensions.Join``1(System.Collections.Generic.IEnumerable{``0},System.String)')
- [FilteredAndPagedList\`2](#T-DotNetHelpers-Models-FilteredAndPagedList`2 'DotNetHelpers.Models.FilteredAndPagedList`2')
- [Language](#T-DotNetHelpers-Models-Language 'DotNetHelpers.Models.Language')
  - [Acronym](#P-DotNetHelpers-Models-Language-Acronym 'DotNetHelpers.Models.Language.Acronym')
  - [Caption](#P-DotNetHelpers-Models-Language-Caption 'DotNetHelpers.Models.Language.Caption')
  - [Culture](#P-DotNetHelpers-Models-Language-Culture 'DotNetHelpers.Models.Language.Culture')
  - [Icon](#P-DotNetHelpers-Models-Language-Icon 'DotNetHelpers.Models.Language.Icon')
- [LetterConverter](#T-DotNetHelpers-LetterConverter 'DotNetHelpers.LetterConverter')
  - [GeoToLatin(source)](#M-DotNetHelpers-LetterConverter-GeoToLatin-System-String- 'DotNetHelpers.LetterConverter.GeoToLatin(System.String)')
  - [LatinToGeo(source)](#M-DotNetHelpers-LetterConverter-LatinToGeo-System-String- 'DotNetHelpers.LetterConverter.LatinToGeo(System.String)')
- [LoggerConfiguration](#T-DotNetHelpers-Logger-LoggerConfiguration 'DotNetHelpers.Logger.LoggerConfiguration')
  - [Build()](#M-DotNetHelpers-Logger-LoggerConfiguration-Build 'DotNetHelpers.Logger.LoggerConfiguration.Build')
  - [SetConnectionString(connectionString)](#M-DotNetHelpers-Logger-LoggerConfiguration-SetConnectionString-System-String- 'DotNetHelpers.Logger.LoggerConfiguration.SetConnectionString(System.String)')
  - [SetSchema(schema)](#M-DotNetHelpers-Logger-LoggerConfiguration-SetSchema-System-String- 'DotNetHelpers.Logger.LoggerConfiguration.SetSchema(System.String)')
  - [SetTable(table)](#M-DotNetHelpers-Logger-LoggerConfiguration-SetTable-System-String- 'DotNetHelpers.Logger.LoggerConfiguration.SetTable(System.String)')
- [LoggerException](#T-DotNetHelpers-Exceptions-LoggerException 'DotNetHelpers.Exceptions.LoggerException')
  - [#ctor()](#M-DotNetHelpers-Exceptions-LoggerException-#ctor 'DotNetHelpers.Exceptions.LoggerException.#ctor')
  - [#ctor()](#M-DotNetHelpers-Exceptions-LoggerException-#ctor-System-String- 'DotNetHelpers.Exceptions.LoggerException.#ctor(System.String)')
  - [#ctor()](#M-DotNetHelpers-Exceptions-LoggerException-#ctor-System-String,System-Exception- 'DotNetHelpers.Exceptions.LoggerException.#ctor(System.String,System.Exception)')
- [ObjectExtentions](#T-DotNetHelpers-Extentions-ObjectExtentions 'DotNetHelpers.Extentions.ObjectExtentions')
  - [ThrowIfNull(source,parameterName)](#M-DotNetHelpers-Extentions-ObjectExtentions-ThrowIfNull-System-Object,System-String- 'DotNetHelpers.Extentions.ObjectExtentions.ThrowIfNull(System.Object,System.String)')
- [OrderByExtentions](#T-DotNetHelpers-Extentions-OrderByExtentions 'DotNetHelpers.Extentions.OrderByExtentions')
  - [OrderByDescending\`\`1(source,propertyName)](#M-DotNetHelpers-Extentions-OrderByExtentions-OrderByDescending``1-System-Linq-IQueryable{``0},System-String- 'DotNetHelpers.Extentions.OrderByExtentions.OrderByDescending``1(System.Linq.IQueryable{``0},System.String)')
  - [OrderBy\`\`1(source,propertyName)](#M-DotNetHelpers-Extentions-OrderByExtentions-OrderBy``1-System-Linq-IQueryable{``0},System-String- 'DotNetHelpers.Extentions.OrderByExtentions.OrderBy``1(System.Linq.IQueryable{``0},System.String)')
- [PagedList\`1](#T-DotNetHelpers-Models-PagedList`1 'DotNetHelpers.Models.PagedList`1')
  - [Items](#P-DotNetHelpers-Models-PagedList`1-Items 'DotNetHelpers.Models.PagedList`1.Items')
  - [Paging](#P-DotNetHelpers-Models-PagedList`1-Paging 'DotNetHelpers.Models.PagedList`1.Paging')
  - [Sorting](#P-DotNetHelpers-Models-PagedList`1-Sorting 'DotNetHelpers.Models.PagedList`1.Sorting')
- [Paging](#T-DotNetHelpers-Models-Paging 'DotNetHelpers.Models.Paging')
  - [#ctor()](#M-DotNetHelpers-Models-Paging-#ctor 'DotNetHelpers.Models.Paging.#ctor')
  - [#ctor(page,perPage)](#M-DotNetHelpers-Models-Paging-#ctor-System-Int32,System-Int32- 'DotNetHelpers.Models.Paging.#ctor(System.Int32,System.Int32)')
  - [#ctor(page,perPage,totalCount,pageCount)](#M-DotNetHelpers-Models-Paging-#ctor-System-Int32,System-Int32,System-Int32,System-Int32- 'DotNetHelpers.Models.Paging.#ctor(System.Int32,System.Int32,System.Int32,System.Int32)')
  - [CurrentPage](#P-DotNetHelpers-Models-Paging-CurrentPage 'DotNetHelpers.Models.Paging.CurrentPage')
  - [PageCount](#P-DotNetHelpers-Models-Paging-PageCount 'DotNetHelpers.Models.Paging.PageCount')
  - [PerPage](#P-DotNetHelpers-Models-Paging-PerPage 'DotNetHelpers.Models.Paging.PerPage')
  - [TotalCount](#P-DotNetHelpers-Models-Paging-TotalCount 'DotNetHelpers.Models.Paging.TotalCount')
- [Result](#T-DotNetHelpers-Models-Result 'DotNetHelpers.Models.Result')
  - [BadRequest](#P-DotNetHelpers-Models-Result-BadRequest 'DotNetHelpers.Models.Result.BadRequest')
  - [Code](#P-DotNetHelpers-Models-Result-Code 'DotNetHelpers.Models.Result.Code')
  - [EntityNotFound](#P-DotNetHelpers-Models-Result-EntityNotFound 'DotNetHelpers.Models.Result.EntityNotFound')
  - [Errors](#P-DotNetHelpers-Models-Result-Errors 'DotNetHelpers.Models.Result.Errors')
  - [Forbidden](#P-DotNetHelpers-Models-Result-Forbidden 'DotNetHelpers.Models.Result.Forbidden')
  - [InternalError](#P-DotNetHelpers-Models-Result-InternalError 'DotNetHelpers.Models.Result.InternalError')
  - [Succeeded](#P-DotNetHelpers-Models-Result-Succeeded 'DotNetHelpers.Models.Result.Succeeded')
- [ResultCode](#T-DotNetHelpers-Enums-ResultCode 'DotNetHelpers.Enums.ResultCode')
  - [BadRequest](#F-DotNetHelpers-Enums-ResultCode-BadRequest 'DotNetHelpers.Enums.ResultCode.BadRequest')
  - [EntityNotFound](#F-DotNetHelpers-Enums-ResultCode-EntityNotFound 'DotNetHelpers.Enums.ResultCode.EntityNotFound')
  - [Forbidden](#F-DotNetHelpers-Enums-ResultCode-Forbidden 'DotNetHelpers.Enums.ResultCode.Forbidden')
  - [InternalError](#F-DotNetHelpers-Enums-ResultCode-InternalError 'DotNetHelpers.Enums.ResultCode.InternalError')
  - [None](#F-DotNetHelpers-Enums-ResultCode-None 'DotNetHelpers.Enums.ResultCode.None')
  - [Ok](#F-DotNetHelpers-Enums-ResultCode-Ok 'DotNetHelpers.Enums.ResultCode.Ok')
- [ResultExtensions](#T-DotNetHelpers-Extentions-ResultExtensions 'DotNetHelpers.Extentions.ResultExtensions')
  - [WithData\`\`1(result,data)](#M-DotNetHelpers-Extentions-ResultExtensions-WithData``1-DotNetHelpers-Models-Result,``0- 'DotNetHelpers.Extentions.ResultExtensions.WithData``1(DotNetHelpers.Models.Result,``0)')
  - [WithEmptyData\`\`1(result)](#M-DotNetHelpers-Extentions-ResultExtensions-WithEmptyData``1-DotNetHelpers-Models-Result- 'DotNetHelpers.Extentions.ResultExtensions.WithEmptyData``1(DotNetHelpers.Models.Result)')
  - [WithError(result,message,code)](#M-DotNetHelpers-Extentions-ResultExtensions-WithError-DotNetHelpers-Models-Result,System-String,System-String- 'DotNetHelpers.Extentions.ResultExtensions.WithError(DotNetHelpers.Models.Result,System.String,System.String)')
  - [WithError(result,error)](#M-DotNetHelpers-Extentions-ResultExtensions-WithError-DotNetHelpers-Models-Result,DotNetHelpers-Models-Error- 'DotNetHelpers.Extentions.ResultExtensions.WithError(DotNetHelpers.Models.Result,DotNetHelpers.Models.Error)')
  - [WithError\`\`1(result,message,code)](#M-DotNetHelpers-Extentions-ResultExtensions-WithError``1-DotNetHelpers-Models-Result,System-String,System-String- 'DotNetHelpers.Extentions.ResultExtensions.WithError``1(DotNetHelpers.Models.Result,System.String,System.String)')
  - [WithError\`\`1(result,error)](#M-DotNetHelpers-Extentions-ResultExtensions-WithError``1-DotNetHelpers-Models-Result{``0},DotNetHelpers-Models-Error- 'DotNetHelpers.Extentions.ResultExtensions.WithError``1(DotNetHelpers.Models.Result{``0},DotNetHelpers.Models.Error)')
  - [WithErrors(result,messages,code)](#M-DotNetHelpers-Extentions-ResultExtensions-WithErrors-DotNetHelpers-Models-Result,System-Collections-Generic-IEnumerable{System-String},System-String- 'DotNetHelpers.Extentions.ResultExtensions.WithErrors(DotNetHelpers.Models.Result,System.Collections.Generic.IEnumerable{System.String},System.String)')
  - [WithErrors(result,errors)](#M-DotNetHelpers-Extentions-ResultExtensions-WithErrors-DotNetHelpers-Models-Result,System-Collections-Generic-IEnumerable{DotNetHelpers-Models-Error}- 'DotNetHelpers.Extentions.ResultExtensions.WithErrors(DotNetHelpers.Models.Result,System.Collections.Generic.IEnumerable{DotNetHelpers.Models.Error})')
  - [WithErrors\`\`1(result,messages,code)](#M-DotNetHelpers-Extentions-ResultExtensions-WithErrors``1-DotNetHelpers-Models-Result,System-Collections-Generic-IEnumerable{System-String},System-String- 'DotNetHelpers.Extentions.ResultExtensions.WithErrors``1(DotNetHelpers.Models.Result,System.Collections.Generic.IEnumerable{System.String},System.String)')
  - [WithErrors\`\`1(result,errors)](#M-DotNetHelpers-Extentions-ResultExtensions-WithErrors``1-DotNetHelpers-Models-Result,System-Collections-Generic-IEnumerable{DotNetHelpers-Models-Error}- 'DotNetHelpers.Extentions.ResultExtensions.WithErrors``1(DotNetHelpers.Models.Result,System.Collections.Generic.IEnumerable{DotNetHelpers.Models.Error})')
- [SlagGenerator](#T-DotNetHelpers-SlagGenerator 'DotNetHelpers.SlagGenerator')
  - [GenerateLink(source)](#M-DotNetHelpers-SlagGenerator-GenerateLink-System-String- 'DotNetHelpers.SlagGenerator.GenerateLink(System.String)')
- [StringExtentions](#T-DotNetHelpers-Extentions-StringExtentions 'DotNetHelpers.Extentions.StringExtentions')
  - [IsWithEnglishLetters(value)](#M-DotNetHelpers-Extentions-StringExtentions-IsWithEnglishLetters-System-String- 'DotNetHelpers.Extentions.StringExtentions.IsWithEnglishLetters(System.String)')
  - [IsWithGeorgianLetters(value)](#M-DotNetHelpers-Extentions-StringExtentions-IsWithGeorgianLetters-System-String- 'DotNetHelpers.Extentions.StringExtentions.IsWithGeorgianLetters(System.String)')

<a name='T-DotNetHelpers-Models-Dropdown`1'></a>
## Dropdown\`1 `type`

##### Namespace

DotNetHelpers.Models

##### Summary

Model for dropdowns

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | type of value |

<a name='M-DotNetHelpers-Models-Dropdown`1-#ctor'></a>
### #ctor() `constructor`

##### Summary

empty constructor

##### Parameters

This constructor has no parameters.

<a name='M-DotNetHelpers-Models-Dropdown`1-#ctor-`0,System-String-'></a>
### #ctor(value,text) `constructor`

##### Summary



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [\`0](#T-`0 '`0') | Value |
| text | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Text |

<a name='P-DotNetHelpers-Models-Dropdown`1-Selected'></a>
### Selected `property`

##### Summary

If value is selected

<a name='P-DotNetHelpers-Models-Dropdown`1-Text'></a>
### Text `property`

##### Summary

Text

<a name='P-DotNetHelpers-Models-Dropdown`1-Value'></a>
### Value `property`

##### Summary

Value

<a name='T-DotNetHelpers-Extentions-EnumExtentions'></a>
## EnumExtentions `type`

##### Namespace

DotNetHelpers.Extentions

<a name='M-DotNetHelpers-Extentions-EnumExtentions-GetDisplayName-System-Enum-'></a>
### GetDisplayName(value) `method`

##### Summary

Returns display name of enum value

##### Returns

Name of enum value as string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Enum](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Enum 'System.Enum') | Value of Enum |

<a name='M-DotNetHelpers-Extentions-EnumExtentions-ToCollection``1-System-Type-'></a>
### ToCollection\`\`1() `method`

##### Summary

Converts Enum to collection list

##### Returns

List of collection models

##### Parameters

This method has no parameters.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Type of enum |

<a name='T-DotNetHelpers-Extentions-EnumerableExtensions'></a>
## EnumerableExtensions `type`

##### Namespace

DotNetHelpers.Extentions

<a name='M-DotNetHelpers-Extentions-EnumerableExtensions-Join``1-System-Collections-Generic-IEnumerable{``0},System-String-'></a>
### Join\`\`1(source,separator) `method`

##### Summary

Converts list|array to string with separator

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | List/Array to convert |
| separator | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | string to use to separate List/Array items |

<a name='T-DotNetHelpers-Models-FilteredAndPagedList`2'></a>
## FilteredAndPagedList\`2 `type`

##### Namespace

DotNetHelpers.Models

##### Summary

Paged list of filtered itmes

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Type of items |
| TFilter | Type of items filter |

<a name='T-DotNetHelpers-Models-Language'></a>
## Language `type`

##### Namespace

DotNetHelpers.Models

<a name='P-DotNetHelpers-Models-Language-Acronym'></a>
### Acronym `property`

##### Summary

Short name for language

<a name='P-DotNetHelpers-Models-Language-Caption'></a>
### Caption `property`

##### Summary

Caption of language

<a name='P-DotNetHelpers-Models-Language-Culture'></a>
### Culture `property`

##### Summary

Culture of language

<a name='P-DotNetHelpers-Models-Language-Icon'></a>
### Icon `property`

##### Summary

Icon for language

<a name='T-DotNetHelpers-LetterConverter'></a>
## LetterConverter `type`

##### Namespace

DotNetHelpers

<a name='M-DotNetHelpers-LetterConverter-GeoToLatin-System-String-'></a>
### GeoToLatin(source) `method`

##### Summary

Convert georgian string to latin letters

##### Returns

String with latin letters

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | String with georgian letters |

<a name='M-DotNetHelpers-LetterConverter-LatinToGeo-System-String-'></a>
### LatinToGeo(source) `method`

##### Summary

Convert latin string to georgian letters

##### Returns

String with latin letters

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | String with georgian letters |

<a name='T-DotNetHelpers-Logger-LoggerConfiguration'></a>
## LoggerConfiguration `type`

##### Namespace

DotNetHelpers.Logger

##### Summary

Configure logger

<a name='M-DotNetHelpers-Logger-LoggerConfiguration-Build'></a>
### Build() `method`

##### Summary

Finishing logger setup

##### Parameters

This method has no parameters.

<a name='M-DotNetHelpers-Logger-LoggerConfiguration-SetConnectionString-System-String-'></a>
### SetConnectionString(connectionString) `method`

##### Summary

Set connection string for logger

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| connectionString | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Connection string |

<a name='M-DotNetHelpers-Logger-LoggerConfiguration-SetSchema-System-String-'></a>
### SetSchema(schema) `method`

##### Summary

Set database schema name for logger

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| schema | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Database schema name |

<a name='M-DotNetHelpers-Logger-LoggerConfiguration-SetTable-System-String-'></a>
### SetTable(table) `method`

##### Summary

Set database table name for logger

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| table | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Database table name |

<a name='T-DotNetHelpers-Exceptions-LoggerException'></a>
## LoggerException `type`

##### Namespace

DotNetHelpers.Exceptions

##### Summary

Logger Exception

<a name='M-DotNetHelpers-Exceptions-LoggerException-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty Constructor

##### Parameters

This constructor has no parameters.

<a name='M-DotNetHelpers-Exceptions-LoggerException-#ctor-System-String-'></a>
### #ctor() `constructor`

##### Summary

Constructor with messages

##### Parameters

This constructor has no parameters.

<a name='M-DotNetHelpers-Exceptions-LoggerException-#ctor-System-String,System-Exception-'></a>
### #ctor() `constructor`

##### Summary

Constructor with messages and inner exception

##### Parameters

This constructor has no parameters.

<a name='T-DotNetHelpers-Extentions-ObjectExtentions'></a>
## ObjectExtentions `type`

##### Namespace

DotNetHelpers.Extentions

##### Summary

Object Extentions

<a name='M-DotNetHelpers-Extentions-ObjectExtentions-ThrowIfNull-System-Object,System-String-'></a>
### ThrowIfNull(source,parameterName) `method`

##### Summary

Throws Argmunet null exception if object is null

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Object to check |
| parameterName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Name of parameter |

<a name='T-DotNetHelpers-Extentions-OrderByExtentions'></a>
## OrderByExtentions `type`

##### Namespace

DotNetHelpers.Extentions

##### Summary

Order by extention

<a name='M-DotNetHelpers-Extentions-OrderByExtentions-OrderByDescending``1-System-Linq-IQueryable{``0},System-String-'></a>
### OrderByDescending\`\`1(source,propertyName) `method`

##### Summary

Orders descending by propertyName

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Linq.IQueryable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.IQueryable 'System.Linq.IQueryable{``0}') | List to order |
| propertyName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Property name |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TSource | Type of list to order |

<a name='M-DotNetHelpers-Extentions-OrderByExtentions-OrderBy``1-System-Linq-IQueryable{``0},System-String-'></a>
### OrderBy\`\`1(source,propertyName) `method`

##### Summary

Orders by propertyName

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Linq.IQueryable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.IQueryable 'System.Linq.IQueryable{``0}') | List to order |
| propertyName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Property name |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TSource | Type of list to order |

<a name='T-DotNetHelpers-Models-PagedList`1'></a>
## PagedList\`1 `type`

##### Namespace

DotNetHelpers.Models

##### Summary

Paged list of itmes

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Type of items |

<a name='P-DotNetHelpers-Models-PagedList`1-Items'></a>
### Items `property`

##### Summary

List of items

<a name='P-DotNetHelpers-Models-PagedList`1-Paging'></a>
### Paging `property`

##### Summary

Paging

<a name='P-DotNetHelpers-Models-PagedList`1-Sorting'></a>
### Sorting `property`

##### Summary

Sorting

<a name='T-DotNetHelpers-Models-Paging'></a>
## Paging `type`

##### Namespace

DotNetHelpers.Models

##### Summary

Paging Model

<a name='M-DotNetHelpers-Models-Paging-#ctor'></a>
### #ctor() `constructor`

##### Summary

Default Constructor

##### Parameters

This constructor has no parameters.

<a name='M-DotNetHelpers-Models-Paging-#ctor-System-Int32,System-Int32-'></a>
### #ctor(page,perPage) `constructor`

##### Summary



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| page | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Current page |
| perPage | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Items per page |

<a name='M-DotNetHelpers-Models-Paging-#ctor-System-Int32,System-Int32,System-Int32,System-Int32-'></a>
### #ctor(page,perPage,totalCount,pageCount) `constructor`

##### Summary



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| page | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Current page |
| perPage | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Items per page |
| totalCount | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Items total count |
| pageCount | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | page count |

<a name='P-DotNetHelpers-Models-Paging-CurrentPage'></a>
### CurrentPage `property`

##### Summary

Current Page

<a name='P-DotNetHelpers-Models-Paging-PageCount'></a>
### PageCount `property`

##### Summary

Page Count

<a name='P-DotNetHelpers-Models-Paging-PerPage'></a>
### PerPage `property`

##### Summary

Items per page

<a name='P-DotNetHelpers-Models-Paging-TotalCount'></a>
### TotalCount `property`

##### Summary

Total count of items

<a name='T-DotNetHelpers-Models-Result'></a>
## Result `type`

##### Namespace

DotNetHelpers.Models

##### Summary

Result class

<a name='P-DotNetHelpers-Models-Result-BadRequest'></a>
### BadRequest `property`

##### Summary

If the request is bad

<a name='P-DotNetHelpers-Models-Result-Code'></a>
### Code `property`

##### Summary

Error Code

<a name='P-DotNetHelpers-Models-Result-EntityNotFound'></a>
### EntityNotFound `property`

##### Summary

If the entity is not found

<a name='P-DotNetHelpers-Models-Result-Errors'></a>
### Errors `property`

##### Summary

Errors

<a name='P-DotNetHelpers-Models-Result-Forbidden'></a>
### Forbidden `property`

##### Summary

If the request is forbidden

<a name='P-DotNetHelpers-Models-Result-InternalError'></a>
### InternalError `property`

##### Summary

If there is an internal error

<a name='P-DotNetHelpers-Models-Result-Succeeded'></a>
### Succeeded `property`

##### Summary

If the result is successful

<a name='T-DotNetHelpers-Enums-ResultCode'></a>
## ResultCode `type`

##### Namespace

DotNetHelpers.Enums

##### Summary

Result code enum

<a name='F-DotNetHelpers-Enums-ResultCode-BadRequest'></a>
### BadRequest `constants`

##### Summary

Bad request result

<a name='F-DotNetHelpers-Enums-ResultCode-EntityNotFound'></a>
### EntityNotFound `constants`

##### Summary

Entity Not Found result

<a name='F-DotNetHelpers-Enums-ResultCode-Forbidden'></a>
### Forbidden `constants`

##### Summary

Forbidden result

<a name='F-DotNetHelpers-Enums-ResultCode-InternalError'></a>
### InternalError `constants`

##### Summary

Internal error result

<a name='F-DotNetHelpers-Enums-ResultCode-None'></a>
### None `constants`

##### Summary

None

<a name='F-DotNetHelpers-Enums-ResultCode-Ok'></a>
### Ok `constants`

##### Summary

Ok result

<a name='T-DotNetHelpers-Extentions-ResultExtensions'></a>
## ResultExtensions `type`

##### Namespace

DotNetHelpers.Extentions

##### Summary

Result extensions

<a name='M-DotNetHelpers-Extentions-ResultExtensions-WithData``1-DotNetHelpers-Models-Result,``0-'></a>
### WithData\`\`1(result,data) `method`

##### Summary

Add data to result

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| result | [DotNetHelpers.Models.Result](#T-DotNetHelpers-Models-Result 'DotNetHelpers.Models.Result') | Result model |
| data | [\`\`0](#T-``0 '``0') | Data |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Type of result data |

<a name='M-DotNetHelpers-Extentions-ResultExtensions-WithEmptyData``1-DotNetHelpers-Models-Result-'></a>
### WithEmptyData\`\`1(result) `method`

##### Summary

Add empty data type to result

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| result | [DotNetHelpers.Models.Result](#T-DotNetHelpers-Models-Result 'DotNetHelpers.Models.Result') | Result model |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-DotNetHelpers-Extentions-ResultExtensions-WithError-DotNetHelpers-Models-Result,System-String,System-String-'></a>
### WithError(result,message,code) `method`

##### Summary

Add error to result

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| result | [DotNetHelpers.Models.Result](#T-DotNetHelpers-Models-Result 'DotNetHelpers.Models.Result') | Result model |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Error message |
| code | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Error code |

<a name='M-DotNetHelpers-Extentions-ResultExtensions-WithError-DotNetHelpers-Models-Result,DotNetHelpers-Models-Error-'></a>
### WithError(result,error) `method`

##### Summary

Add error to result

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| result | [DotNetHelpers.Models.Result](#T-DotNetHelpers-Models-Result 'DotNetHelpers.Models.Result') | Result model |
| error | [DotNetHelpers.Models.Error](#T-DotNetHelpers-Models-Error 'DotNetHelpers.Models.Error') | Error model |

<a name='M-DotNetHelpers-Extentions-ResultExtensions-WithError``1-DotNetHelpers-Models-Result,System-String,System-String-'></a>
### WithError\`\`1(result,message,code) `method`

##### Summary

Add error to result

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| result | [DotNetHelpers.Models.Result](#T-DotNetHelpers-Models-Result 'DotNetHelpers.Models.Result') | Result model |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Error message |
| code | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Error code |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Type of result data |

<a name='M-DotNetHelpers-Extentions-ResultExtensions-WithError``1-DotNetHelpers-Models-Result{``0},DotNetHelpers-Models-Error-'></a>
### WithError\`\`1(result,error) `method`

##### Summary

Add error to result

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| result | [DotNetHelpers.Models.Result{\`\`0}](#T-DotNetHelpers-Models-Result{``0} 'DotNetHelpers.Models.Result{``0}') | Result model |
| error | [DotNetHelpers.Models.Error](#T-DotNetHelpers-Models-Error 'DotNetHelpers.Models.Error') | Error model |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Type of result data |

<a name='M-DotNetHelpers-Extentions-ResultExtensions-WithErrors-DotNetHelpers-Models-Result,System-Collections-Generic-IEnumerable{System-String},System-String-'></a>
### WithErrors(result,messages,code) `method`

##### Summary

Add error to result

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| result | [DotNetHelpers.Models.Result](#T-DotNetHelpers-Models-Result 'DotNetHelpers.Models.Result') | Result model |
| messages | [System.Collections.Generic.IEnumerable{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.String}') | List of error messages |
| code | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Error code |

<a name='M-DotNetHelpers-Extentions-ResultExtensions-WithErrors-DotNetHelpers-Models-Result,System-Collections-Generic-IEnumerable{DotNetHelpers-Models-Error}-'></a>
### WithErrors(result,errors) `method`

##### Summary

Add error to result

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| result | [DotNetHelpers.Models.Result](#T-DotNetHelpers-Models-Result 'DotNetHelpers.Models.Result') | Result model |
| errors | [System.Collections.Generic.IEnumerable{DotNetHelpers.Models.Error}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{DotNetHelpers.Models.Error}') | List of errors |

<a name='M-DotNetHelpers-Extentions-ResultExtensions-WithErrors``1-DotNetHelpers-Models-Result,System-Collections-Generic-IEnumerable{System-String},System-String-'></a>
### WithErrors\`\`1(result,messages,code) `method`

##### Summary

Add error to result

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| result | [DotNetHelpers.Models.Result](#T-DotNetHelpers-Models-Result 'DotNetHelpers.Models.Result') | Result model |
| messages | [System.Collections.Generic.IEnumerable{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.String}') | List of error messages |
| code | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Error code |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Type of result data |

<a name='M-DotNetHelpers-Extentions-ResultExtensions-WithErrors``1-DotNetHelpers-Models-Result,System-Collections-Generic-IEnumerable{DotNetHelpers-Models-Error}-'></a>
### WithErrors\`\`1(result,errors) `method`

##### Summary

Add error to result

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| result | [DotNetHelpers.Models.Result](#T-DotNetHelpers-Models-Result 'DotNetHelpers.Models.Result') | Result model |
| errors | [System.Collections.Generic.IEnumerable{DotNetHelpers.Models.Error}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{DotNetHelpers.Models.Error}') | List of errors |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Type of result data |

<a name='T-DotNetHelpers-SlagGenerator'></a>
## SlagGenerator `type`

##### Namespace

DotNetHelpers

##### Summary

Generate Slags

<a name='M-DotNetHelpers-SlagGenerator-GenerateLink-System-String-'></a>
### GenerateLink(source) `method`

##### Summary

Generate string for url

##### Returns

Url friendly string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Source |

<a name='T-DotNetHelpers-Extentions-StringExtentions'></a>
## StringExtentions `type`

##### Namespace

DotNetHelpers.Extentions

<a name='M-DotNetHelpers-Extentions-StringExtentions-IsWithEnglishLetters-System-String-'></a>
### IsWithEnglishLetters(value) `method`

##### Summary

Checks if string contains only english letters

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-DotNetHelpers-Extentions-StringExtentions-IsWithGeorgianLetters-System-String-'></a>
### IsWithGeorgianLetters(value) `method`

##### Summary

Checks if string contains only georgian letters

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
