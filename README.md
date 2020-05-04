# DotNetHelpers

## Contents

## EnumExtentions `type`

##### Namespace

DotNetHelpers.Extentions

### GetDisplayName(value) `method`

##### Summary

Returns display name of enum value

##### Returns

Name of enum value as string

##### Parameters

| Name  | Type                                                                                                              | Description   |
| ----- | ----------------------------------------------------------------------------------------------------------------- | ------------- |
| value | [System.Enum](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Enum "System.Enum") | Value of Enum |

### ToCollection() `method`

##### Summary

Converts Enum to collection list

##### Returns

List of collection models

##### Parameters

This method has no parameters.

##### Generic Types

| Name | Description  |
| ---- | ------------ |
| T    | Type of enum |

## EnumerableExtensions `type`

##### Namespace

DotNetHelpers.Extentions

### Join(source,separator) `method`

##### Summary

Converts list|array to string with separator

##### Returns

##### Parameters

| Name      | Type                                                                                                                                                                                                                                   | Description                                |
| --------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------ |
| source    | [System.Collections.Generic.IEnumerable](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable "System.Collections.Generic.IEnumerable{``0}") | List/Array to convert |
| separator | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String")                                                                                                                | string to use to separate List/Array items |

## FilteredAndPagedList `type`

##### Namespace

DotNetHelpers.Models

##### Summary

Paged list of filtered itmes

##### Generic Types

| Name    | Description          |
| ------- | -------------------- |
| T       | Type of items        |
| TFilter | Type of items filter |

## Language `type`

##### Namespace

DotNetHelpers.Models

### Acronym `property`

##### Summary

Short name for language

### Caption `property`

##### Summary

Caption of language

### Culture `property`

##### Summary

Culture of language

### Icon `property`

##### Summary

Icon for language

## LetterConverter `type`

##### Namespace

DotNetHelpers

### GeoToLatin(source) `method`

##### Summary

Convert georgian string to latin letters

##### Returns

String with latin letters

##### Parameters

| Name   | Type                                                                                                                    | Description                  |
| ------ | ----------------------------------------------------------------------------------------------------------------------- | ---------------------------- |
| source | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String") | String with georgian letters |

### LatinToGeo(source) `method`

##### Summary

Convert latin string to georgian letters

##### Returns

String with latin letters

##### Parameters

| Name   | Type                                                                                                                    | Description                  |
| ------ | ----------------------------------------------------------------------------------------------------------------------- | ---------------------------- |
| source | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String") | String with georgian letters |

## ObjectExtentions `type`

##### Namespace

DotNetHelpers.Extentions

### ThrowIfNull(source) `method`

##### Summary

Throws Argmunet null exception if object is null

##### Parameters

| Name   | Type                                                                                                                    | Description     |
| ------ | ----------------------------------------------------------------------------------------------------------------------- | --------------- |
| source | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object "System.Object") | Object to check |

## PagedList `type`

##### Namespace

DotNetHelpers.Models

##### Summary

Paged list of itmes

##### Generic Types

| Name | Description   |
| ---- | ------------- |
| T    | Type of items |

### Items `property`

##### Summary

List of items

### Paging `property`

##### Summary

Paging

### Sorting `property`

##### Summary

Sorting

## Paging `type`

##### Namespace

DotNetHelpers.Models

### CurrentPage `property`

##### Summary

Current Page

### PageCount `property`

##### Summary

Page Count

### PerPage `property`

##### Summary

Items per page

### TotalCount `property`

##### Summary

Total count of items

## Result `type`

##### Namespace

DotNetHelpers.Models

### AddError(errorMessage) `method`

##### Summary

Add new error

##### Parameters

| Name         | Type                                                                                                                    | Description   |
| ------------ | ----------------------------------------------------------------------------------------------------------------------- | ------------- |
| errorMessage | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String") | Error message |

### AddError(errorMessage,isException) `method`

##### Summary

Add new error

##### Parameters

| Name         | Type                                                                                                                       | Description                   |
| ------------ | -------------------------------------------------------------------------------------------------------------------------- | ----------------------------- |
| errorMessage | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String")    | Error message                 |
| isException  | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean "System.Boolean") | True if exception is occurred |

### AddError(key,errorMessage) `method`

##### Summary

Add new error

##### Parameters

| Name         | Type                                                                                                                    | Description   |
| ------------ | ----------------------------------------------------------------------------------------------------------------------- | ------------- |
| key          | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String") | Key for error |
| errorMessage | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String") | Error message |

### AddError(key,errorMessage,isException) `method`

##### Summary

Add new error

##### Parameters

| Name         | Type                                                                                                                       | Description                   |
| ------------ | -------------------------------------------------------------------------------------------------------------------------- | ----------------------------- |
| key          | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String")    | Key for error                 |
| errorMessage | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String")    | Error message                 |
| isException  | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean "System.Boolean") | True if exception is occurred |

### AddError(error) `method`

##### Summary

Add new error

##### Parameters

| Name  | Type                                                                                                                                                                                                                                                            | Description               |
| ----- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------- |
| error | [System.Collections.Generic.KeyValuePair{System.String,System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.KeyValuePair "System.Collections.Generic.KeyValuePair{System.String,System.String}") | Key and message for error |

### AddError(error,isException) `method`

##### Summary

Add new errors

##### Parameters

| Name        | Type                                                                                                                                                                                                                                                            | Description                   |
| ----------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------- |
| error       | [System.Collections.Generic.KeyValuePair{System.String,System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.KeyValuePair "System.Collections.Generic.KeyValuePair{System.String,System.String}") | Key and message for error     |
| isException | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean "System.Boolean")                                                                                                                                      | True if exception is occurred |

### AddError(errors) `method`

##### Summary

Add new errors

##### Parameters

| Name   | Type                                                                                                                                                                                                                                                      | Description                          |
| ------ | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------ |
| errors | [System.Collections.Generic.Dictionary{System.String,System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.Dictionary "System.Collections.Generic.Dictionary{System.String,System.String}") | Dictionary of errors Key and message |

### AddErrors(errorMessages) `method`

##### Summary

Add new errors

##### Parameters

| Name          | Type                                                                                                                                                                                                        | Description           |
| ------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | --------------------- |
| errorMessages | [System.Collections.Generic.List{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List "System.Collections.Generic.List{System.String}") | List of error message |

### AddErrors(errors) `method`

##### Summary

Add new error

##### Parameters

| Name   | Type                                                                                                                                                                                                                                                                                                                                           | Description                    |
| ------ | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------ |
| errors | [System.Collections.Generic.IEnumerable{System.Collections.Generic.KeyValuePair{System.String,System.String}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable "System.Collections.Generic.IEnumerable{System.Collections.Generic.KeyValuePair{System.String,System.String}}") | List of errors Key and message |

### Error(errorMessage) `method`

##### Summary

Returns result class instance with error

##### Returns

##### Parameters

| Name         | Type                                                                                                                    | Description   |
| ------------ | ----------------------------------------------------------------------------------------------------------------------- | ------------- |
| errorMessage | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String") | Error message |

### Error(errorMessage) `method`

##### Summary

Returns result class instance with error

##### Returns

##### Parameters

| Name         | Type                                                                                                                    | Description   |
| ------------ | ----------------------------------------------------------------------------------------------------------------------- | ------------- |
| errorMessage | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String") | Error message |

##### Generic Types

| Name | Description           |
| ---- | --------------------- |
| T    | Type of data property |

### Success() `method`

##### Summary

Returns result class instance with success

##### Returns

##### Parameters

This method has no parameters.

### Success() `method`

##### Summary

Returns result class instance with success

##### Returns

##### Parameters

This method has no parameters.

##### Generic Types

| Name | Description           |
| ---- | --------------------- |
| T    | Type of data property |

### Throw(errorMessage) `method`

##### Summary

Returns result class instance with error when exception is occurred

##### Returns

##### Parameters

| Name         | Type                                                                                                                    | Description   |
| ------------ | ----------------------------------------------------------------------------------------------------------------------- | ------------- |
| errorMessage | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String") | Error message |

### Throw(errorMessage) `method`

##### Summary

Returns result class instance with error when exception is occurred

##### Returns

##### Parameters

| Name         | Type                                                                                                                    | Description   |
| ------------ | ----------------------------------------------------------------------------------------------------------------------- | ------------- |
| errorMessage | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String") | Error message |

##### Generic Types

| Name | Description           |
| ---- | --------------------- |
| T    | Type of data property |

## SlagGenerator `type`

##### Namespace

DotNetHelpers

### GenerateLink(source) `method`

##### Summary

Generate string for url

##### Returns

Url friendly string

##### Parameters

| Name   | Type                                                                                                                    | Description |
| ------ | ----------------------------------------------------------------------------------------------------------------------- | ----------- |
| source | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String") | Source      |

## StringExtentions `type`

##### Namespace

DotNetHelpers.Extentions

### IsWithEnglishLetters(value) `method`

##### Summary

Checks if string contains only english letters

##### Returns

##### Parameters

| Name  | Type                                                                                                                    | Description |
| ----- | ----------------------------------------------------------------------------------------------------------------------- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String") |             |

### IsWithGeorgianLetters(value) `method`

##### Summary

Checks if string contains only georgian letters

##### Returns

##### Parameters

| Name  | Type                                                                                                                    | Description |
| ----- | ----------------------------------------------------------------------------------------------------------------------- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String") |             |
