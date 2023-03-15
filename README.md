# Homework - RPG game inventiry &amp; inheritance in c#
 - Completion of the task in <a target="_blank" href="https://github.com/DenisMatsenko/HW-RPG-Inventory/blob/main/ExecutionCzech.md">Czech language</a>
 - Link to <a target="_blank" href="https://github.com/DenisMatsenko/HW-RPG-Inventory/tree/main/Inventory/Assets/Scripts/MyClasses">C# scripts</a>

## ⚪️ Task
### Practical part
Create an application that will capture inventory from an RPG game. 
It will be possible to put different types of items in the inventory that have different properties. 
E.g. food spoils over time, weapons wear out from combat, etc.
The inventory will be able to traverse its contents without directly 
accessing the internal collection in which the items will be stored.
Also create a service application in which it will be
possible to verify the operation of the assignment.

### Written part
In the written part, analyze the principles and possibilities of inheritance, implementation of interfaces, method override and genericity.

## ⚪️ Execution of the practical part
### Inventory features
- Rewinds days which spoils things in the inventory
- Counts inventory weight
- Adding new items using drag and drop from an infinite source

What the game looks like

<img src="https://cdn.discordapp.com/attachments/967125309184950343/1083391940395008130/image.png" width="500px">


The class inheritance scheme that the inventory uses

<img src="https://cdn.discordapp.com/attachments/967125309184950343/1085264648732954756/image.png" width="500px">

## ⚪️ Execution of the written part
### Class inheritance
```
Princip:
 The principle of class inheritance - a data type can inherit at the same
 time extend or change the characteristics (data and functionality) of some
 existing type.

Are used:
 Class inheritance used to minimize code by using already existing code and
 structuring software components for easier orientation in the program code.
```

### Interfaces
```
Princip:
 The princip of interfaces - a type that can define functionality (methods 
 and properties) without an implementation, to apply and implement it in multiple
 classes and structures. Also, classes and structures have the ability to inherit
 an unlimited number of interfaces (unlike class inheritance).

Are used:
 Interface are used for simplified creation of classes and structures with an
 extensive functionality, structuring of software components for easier orientation
 in the program code.
```

### Method override
```
Princip:
 The princip of override method - override method provides a new implementation
 of the method inherited from a base class.

Are used:
 Override method - allowing a derived class to provide a specific implementation
 of a method already implemented in base class.
```

### Generic class
```
Princip:
 The princip of generic class - a class capable of performing the same functionality
 for different data types.

Are used:
 Generic clsses are used in most cases when it is necessary to create a collection
 that is flexible to the type of the contained data.
```
