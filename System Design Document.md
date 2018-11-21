# System design document

![alt System Design scheme(unfinished)](imgfolder/systemDesignScheme.png)

# Testing plan

# Project plan

# Business logic model

# Requirements

# Functional plan

# Logical design

# Physical Design

# Database plan

# Update plan
As it is a web based application, the rollout of the updates might result in temporary downtime. The two exact scenarios are the following:
- In case, we have High Availability system, the updates can be rolled out to the servers one by one, meaning absolutely no downtime.
- In case, we do not have HA system, the server must disconnect any logged in users and should not allow new connections. Then the update can be applied on the server, finally the server can be set again to allow connections.

Updates should happen every month, applying new requirements from every side. The exact time for the update should be the 11th day of every month, at 03:20, as it seems to be the time, when the system would be used the least.

The update development should happen on a scaled down version of the live server, the tesing of the update should begin on the 5th day of every month. Before that, on the 4th of every month, a database cloning should happen from the live server to the test server.
