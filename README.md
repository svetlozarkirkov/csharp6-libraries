C# 6.0 - Libraries
======

[![Build Status](https://travis-ci.org/svetlozarkirkov/csharp6-libraries.svg?branch=master)](https://travis-ci.org/svetlozarkirkov/csharp6-libraries)

###<sub>Target framework: .NET 4.5</sub>


---
### **About**
Implementing various libraries for C# from scratch using C# 6.0 syntax where possible.


### **Goals**
- SOLID
- High Performance
- Complete unit-tests
- Full, correct and useful documentation


----------
<h4>List of libraries (constantly updated) :</h4>
<sub><em>Name of collection -> Abstraction -> Concrete Implementation -> Public Interface and/or Specifics</em>
###<sub>**Collections**</sub>###

 - **Stack**
	 - Base Stack
		 - Standard Stack
			 - Push <em>(adds an item at the top of the stack)</em>
			 - Pop <em>(returns the top item in the stack  and removes it)</em>
			 - Peek <em>(returns the top item in the stack)</em>
			 - Size <em>(returns the count of items in the stack)</em>
		 - Indexed Stack (implements **Standard Stack** and **IIndexer**)
			 - gets an item from the stack by [index] <em>(throws appropriate exception if the index is invalid)</em>
		 - Permanent Stack (implements **Standard Stack**)
			 - Has fixed capacity <em>(throws appropriate exception if capacity is exceeded)</em>


 - **Set**
	 - Base Set
		 - Single-Linked Set 
			 - Add <em>(adds a **Node** to the set)</em>
 - **Node**
	 - ISetNode
		 - Single-Linked Node
			 - <em>holds an item and a pointer to a previous **Node**</em>
			 -  <em>currently deeply coupled to **Single-Linked Set**</em>


 - **Injectors**
	 - Indexer
		 - IIndexer <em>(basic indexing support)</em>

----------

<!--## Download
* [Version 0.2](https://github.com/svetlozarkirkov/csharp6-libraries/archive/master.zip)
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

## Version 
* Version: alpha

## How-to use this code
* see [INSTRUCTIONS](https://github.com/svetlozarkirkov/csharp6-libraries/blob/master/INSTRUCTIONS.md) file

## Contact
#### Developer/Company
* Homepage: http://svetlozarkirkov.xyz
* e-mail: svetlozark@gmail.com
* Twitter: [@svetlozarkirkov](https://twitter.com/svetlozarkirkov "svetlozarkirkov on twitter")
* other communication/social media

[![Flattr this git repo](http://api.flattr.com/button/flattr-badge-large.png)](https://flattr.com/submit/auto?user_id=svetlozarkirkov&url=https://github.com/svetlozarkirkov/csharp6-libraries&title=csharp6-libraries&language=&tags=github&category=software)