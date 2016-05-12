C# 6.0 - Micro Libraries
===

[![Build Status](https://travis-ci.org/svetlozarkirkov/csharp6-libraries.svg?branch=master)](https://travis-ci.org/svetlozarkirkov/csharp6-libraries)

**Target framework: .NET 4.5**

<h2>About</h2>

Various micro libraries for C# written from scratch using C# 6.0 syntax and features.


<h2>Goals</h2>

- :muscle: **SOLID**
- :runner: **High Performance**
- :fries: **Modularity**
- :cop: **Complete unit-tests**
- :books: **Full, correct and useful documentation**
- :link: **Ports to other languages**

## Version
* **Early Alpha**

<h2>Test Dependencies</h2>

|Name|
|---|
|Fluent Assertions|
|NUnit|
|Moq|
|SpecFlow|


<h2>List of libraries (constantly updated ; work in progress):</h2>

#### **Collections** ####

- **Stack** ![Stack](http://i.imgur.com/qGOr4Gj.png?2)
    - **ArrayStack** sub-class
		- Implementations
		
			| Class | Description |
			|---|---|
			| ArrayStack | Default implementation |
			| Permanent ArrayStack | Has fixed capacity |

		- Public interface
		        
			| Method | Description |
			|---|---|
			| Push | Adds an item at the top of the stack |
			| Pop | Returns and removes the top item in the stack |
			| Peek | Returns the top item in the stack |
			| Size | Returns the count of elements in the stack |
			


- **Set**
    - **Node Set** sub-class
		- Implementations
		
			| Class | Description |
			|---|---|
			| Single-Link Set | Default implementation |
	
		- Public interface
		
			| Method | Description |
			|---|---|
			| Add | Adds a node link to the set |
			| Remove (index) | Removes the node link at the given index |

- **Map**
   - **Node Map** sub-class

----------

<!--## Download
* [Early Alpha](https://github.com/svetlozarkirkov/csharp6-libraries/archive/master.zip)
* Other Versions-->

## Usage
```$ git clone https://github.com/svetlozarkirkov/csharp6-libraries.git
...```

## Contributors

### Contributors on GitHub
* [Contributors](https://github.com/svetlozarkirkov/csharp6-libraries/graphs/contributors)

### Translations
* [Transifex](https://www.transifex.com/projects/p/csharp6-libraries/)

### Third party libraries
* see [LIBRARIES](https://github.com/svetlozarkirkov/csharp6-libraries/blob/master/LIBRARIES.md) files

## License 
* see [LICENSE](https://github.com/svetlozarkirkov/csharp6-libraries/blob/master/LICENSE.md) file

## How-to use this code
* see [INSTRUCTIONS](https://github.com/svetlozarkirkov/csharp6-libraries/blob/master/INSTRUCTIONS.md) file

## Contact
#### Developer/Company
* Homepage: http://svetlozarkirkov.xyz
* e-mail: svetlozark@gmail.com
* Twitter: [@svetlozarkirkov](https://twitter.com/svetlozarkirkov "svetlozarkirkov on twitter")
* other communication/social media

[![Flattr this git repo](http://api.flattr.com/button/flattr-badge-large.png)](https://flattr.com/submit/auto?user_id=svetlozarkirkov&url=https://github.com/svetlozarkirkov/csharp6-libraries&title=csharp6-libraries&language=&tags=github&category=software)

