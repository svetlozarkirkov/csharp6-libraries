C# 6.0 - Libraries
======

[![Build Status](https://travis-ci.org/svetlozarkirkov/csharp6-libraries.svg?branch=master)](https://travis-ci.org/svetlozarkirkov/csharp6-libraries)

**Target framework: .NET 4.5**


### **About**
Implementing various libraries for C# from scratch using C# 6.0 syntax where possible.


### **Goals**
- SOLID
- High Performance
- Complete unit-tests
- Full, correct and useful documentation
- Ports to other languages

----------
###**List of libraries (constantly updated):**###

#### **Collections** ####

- **Stack**
    - **Standard Stack** sub-class
		- Injectors
			| Injector | Description |
			|---|---|
			| IIndexable | Access index of the collection |
			| IClearable | Empties the collection |

		- Implementations
		
			| Class | Description |
			|-----|-----|
			| Standard Stack | Default implementation |
			| Permanent Stack | Has fixed capacity |

		- Public interface
		        
			| Method | Description |
			|---|---|
			| Push | Adds an item at the top of the stack |
			| Pop | Returns and removes the top item in the stack |
			| Peek | Returns the top item in the stack |
			| Size | Returns the count of elements in the stack |
			| Clear | Reinitializes the stack |
			| [ ] | Access items in the stack by index |


- **Set**
    - **Single-Link Set** sub-class
        - Single-Link Set with **Private Node**
        - Single-Link Set with **External Node**
        
			| Method | Description |
			|---|---|
			| Add | Adds a node link to the set |
			| Remove (index) | Removes the node link at the given index |


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

