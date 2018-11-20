# Current situation

We already decided what kind of problem to solve. We almost finished our requirment specification. Facebook messenger chat was created for further communications.
Team of developers already divided tasks, so each of us has their own job to do. 
We have additional developer, that joined our team on 14th of Nov 2018.
List of the tasks, which are done:

1. Requirement specification: Dream Chapter.
2. Requirement specification: Current Specification.
3. Requirement specification: Requirements List.
4. Requirement specification: Laws and standards.

#UI plans
1. ScoreBoard is displayed once player(s) finished the certain level in the game
2. 3 difficulty level is diplayed with 3 different colored layers one on top of the other 
3. For simplicity menu items (difficulty level settings etc.) are displayed in card like UI
4. At the top of the screen toggle swith is displayed for full screen and small window UI
5. For multiplayer there will be separete screen in which there player can interreact with eachothers




# Constraints on the system
As per said in the requirement specification, the software must oblige the new requlations in the EU, namely *GDPR*. This means whatever data we collect from the user, must be treated with the utmost care. Also the user **MUST** explicitly accept the collection and use of his/her data.

As stated in the requirement specification, copyright content can be used for educational purposes. Although it varies country-by-country, if the original author/source must be stated or not. This would mean a great constraint on the system in case of commercialising the software. In case of free educational software, the differences between the countries does no concern us, we will only have to oblige to the laws in the country, where our organization is stated, and where the original source of the server side of the software is. Even if CDN is used, the original source is the one we have to oblige.

As per said in the requirement specification, whenever communications happen between the client and server side, the data should be sent in a json format. It is one of the most popular standards nowadays. If the communication happens on http/https protocol, it is also a good idea to use normalized url-s with it, similarly to a RESTful API.


# What it should be, and what it should not be.
It's should simply be compatible with many platforms such as Android and web browser even IOS.
it should be with a perfect design to attract users to try our app!

# Used Cases
Teacher
-Will be able to create and upload learning material.
-Will be able to check the progress of the students.
-Will be able to examine the response pattern made by students.
-Will be able to alter the difficulty level of each question.

Learners
-Will be able to answer the questions by choosing the most unlikely or likely answer depending on the question.
-Will be able to choose the difficulty of each play.
-Will be able to receive feedback on their progress.
-Will be able get a more visual learning experience.


