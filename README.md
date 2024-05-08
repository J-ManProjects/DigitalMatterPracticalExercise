# Digital Matter Practical Exercise
This is the complete source code and results for the practical exercise from Digital Matter
* **Author:** Jacques Malan
* **Due date:** 9 May 2024

## Background:
You have been tasked to design a database for an IoT asset tracking and sensor monitoring hardware company. The company has multiple different device types on offer, each with varying capabilities.

## Task:
Design a database schema for a hierarchical grouping of IoT devices.
* Devices have Firmware.
* Firmware is versioned – and a Device has a certain version of Firmware.
* A Group can form part of another Group.
* A Device can be linked to a Group.

## Deliverables:
1. Create the scripts to create the database structure and populate it with a few records in each table.
2. Create a web application that can manage Groups and Firmware for devices.

## Tech Stack:
* We prefer `MSSQL` and `.NET` (`C#`, `HTML`, `JS`, `CSS`) however we will accept it in another stack provided the solution is well documented.


## Design:
The designed database schema is illustrated below:
![database schema](Images/database_schema.png)
The reasoning is as follows:
* Firmware is written for a specific device, leading to a many-to-one relationship between firmware and devices.
* As groups can be a part of another group, each group can (optionally) be linked to a parent group.
* Since multiple devices can be part of a single group, and multiple groups can contain the same device, the relationship between devices and groups are many-to-many. The solution is the Connections join table that directly links groups and devices via their respective IDs.
