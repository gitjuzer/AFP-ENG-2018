# System design document

![alt System Design scheme(unfinished)](imgfolder/systemDesignScheme.png)

# Testing plan

Software Testing Methodology is defined as strategies and testing types used to certify that the Application Under Test meets client expectations. Test Methodologies include functional and non-functional testing to validate the AUT. Examples of Testing Methodologies are Unit Testing, Integration Testing, System Testing, Performance Testing etc. Each testing methodology has a defined test objective, test strategy and deliverables.


1. Unit Testing:
Unit Testing of software applications is done during the development (coding) of an application.

The objective of Unit Testing is to isolate a section of code and verify its correctness. In procedural programming a unit may be an individual function or procedure

The goal of Unit Testing is to isolate each part of the program and show that the individual parts are correct. Unit Testing is usually performed by the developer.

_Createing Unit Test Cases:
Unit testing is commonly automated, but may still be performed manually. The IEEE does not favor one over the other. A manual approach to unit testing may employ a step-by-step instructional document.

Under the automated approach-

* A developer could write another section of code in the application just to test the function. They would later comment out and finally remove the test code when the application is done.
* They could also isolate the function to test it more rigorously. This is a more thorough unit testing practice that involves copy and pasting the function into its own testing environment to other than its natural environment. Isolating the code helps in revealing unnecessary dependencies between the code being tested and other units or data spaces in the product. These dependencies can then be eliminated.
 

A coder may use a UnitTest Framework to develop automated test cases. Using an automation framework, the developer codes criteria into the test to verify the correctness of the unit. During execution of the test cases, the framework logs those that fail any criterion. Many frameworks will also automatically flag and report in summary these failed test cases. Depending on the severity of a failure, the framework may halt subsequent testing.

_Unit Testing Tools
There are several automated tools available to assist with unit testing. We will provide a few examples below:

Jtest: Parasoft Jtest is an IDE plugin that leverages open-source frameworks (Junit, Mockito, PowerMock, and Spring) with guided and easy one-click actions for creating, scaling, and maintaining unit tests. By automating these time-consuming aspects of unit testing, it frees the developer to focus on business logic and create more meaningful test suites.
Junit: Junit is a free to use testing tool used for Java programming language.  It provides assertions to identify test method. This tool test data first and then inserted in the piece of code.
NUnit:  NUnit is widely used unit-testing framework use for all .net languages.  It is open source tool which allows writing scripts manually. It supports data-driven tests which can run in parallel.
JMockit:  JMockit is open source Unit testing tool.  It is code coverage tool with line and path metrics. It allows mocking API with recording and verification syntax. This tool offers Line coverage, Path Coverage, and Data Coverage.
EMMA:  EMMA is an open-source toolkit for analyzing and reporting code written in Java language. Emma support coverage types like method, line, basic block. It is Java-based so it is without external library dependencies and can access to the source code.
PHPUnit: PHPUnit is a unit testing tool for PHP programmer. It takes small portions of code which is called units and test each of them separately.  The tool also allows developers to use pre-define assertion methods to assert that system behave in a certain manner. 
Those are just a few of the available unit testing tools. There are lots more, especially for C languages and Java, but you are sure to find a unit testing tool for your programming needs regardless of the language you use.

2. Integration Testing:
In integration Testing, individual software modules are integrated logically and tested as a group.

A typical software project consists of multiple software modules, coded by different programmers.

 integration Testing focuses on checking data communication amongst these modules.

Hence it is also termed as 'I & T' (Integration and Testing), 'String Testing' and sometimes 'Thread Testing'.

_Guidelines for Integration Testing
* First determine the Integration Test Strategy that could be adopted and later prepare the test cases and test data accordingly.
* Study the Architecture design of the Application and identify the Critical Modules. These need to be tested on priority.
* Obtain the interface designs from the Architectural team and create test cases to verify all of the interfaces in detail. Interface to database/external hardware/software application must be tested in detail.
* After the test cases, it's the test data which plays the critical role.
* Always have the mock data prepared, prior to executing. Do not select test data while executing the test cases.


# Project plan

1. Game Project
2. Scrum Master : Miklos Kovacs
3. Team Memmbers: Aziz Gasimov , Maksat Baigazy, Miklos Kovacs, Amer Mamoun , Xolani Nhlapon, Rayne Blair, Kaddour Srarfi, Chihep Njr
-- Tasks Assigned for members:
1. Project Plan: Aziz Gasimov
2. Testing Plan: Amer Mamoun
3. Database Plan: Maksat Baigazy
4. Functional Plan: Xolani Nhlapon
5. Physical Design: Rayne Blair
6. Business logic model:  Kaddour Srarfi




# Business logic model

# Requirements

# Functional plan

# Logical design

# Physical Design


# Database plan

We need to have a database for our project, at least 2 tables: Users and Data table for app use.
In user table we will have 4 columns:

1. id (int, AI)
2. username (varchar, unique)
3. password (varchar)
4. email (varchar, unique)


# Update plan
As it is a *web based application*, the rollout of the updates **might** result in *temporary downtime*. The two exact scenarios are the following:
- In case, **we have *High Availability*** system, the updates can be rolled out to the servers one by one, meaning absolutely *no downtime*.
- In case, **we do not have *HA* system**, the server must *disconnect* any *logged in users* and should *not allow new connections*. Then the update can be applied on the server, finally the server can be set again to allow connections.

Updates should happen **every month**, applying new requirements from every side. The exact time for the update should be the *11th day of every month*, at *03:20*, as it seems to be the time, when the system would be used the least.

It is a **must**, that we make a *backup* before an update happens. The backup should be a **full database, and filesystem backup**. The automation of this sys is *recommended*.

The *update development* should happen on a *scaled down version of the live server*, the **tesing of the update should begin on the 5th day of every month**. Before that, on the 4th of every month, a *database cloning* should happen from the live server **to the test server**.
