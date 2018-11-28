# System design document

![alt System Design scheme(unfinished)](imgfolder/systemDesignScheme.png)

# Testing plan

Software Testing Methodology is defined as strategies and testing types used to certify that the Application Under Test meets client expectations. Test Methodologies include functional and non-functional testing to validate the AUT. Examples of Testing Methodologies are Unit Testing, Integration Testing, System Testing, Performance Testing etc. Each testing methodology has a defined test objective, test strategy and deliverables.


1. Unit Testing:
Unit Testing of software applications is done during the development (coding) of an application.

The objective of Unit Testing is to isolate a section of code and verify its correctness. In procedural programming a unit may be an individual function or procedure

The goal of Unit Testing is to isolate each part of the program and show that the individual parts are correct. Unit Testing is usually performed by the developer.

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
