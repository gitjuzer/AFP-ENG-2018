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
Actors: Teacher and Student

UC-1 	<create and upload learning material> 
Primary Actor(s)	< Teacher>
Description	<The teacher will be able to create and upload learning material for the learners to use.>
Trigger	<When learning material is too old. 
         When previous learning material has been updated but have not been uploaded.>
Pre-conditions	<The old learning material has not been altered/changed/updated. > 
Post-conditions	<The new updated learning material is in use.> 
Main Success Scenario	
1.	Check if old learning material hass been updated, if not.
2.	Upload new learning material
3.	New learning material should be uploaded and used.
  
Extensions	If Condition, then Alternative Steps
<If the learning material has been updated/created then do not update learning material.>
Priority	<To have latest learning material in the game)
Special Requirements	<none> 
Open Questions	<none>

UC-2 	<Check Progress> 
Primary Actor(s)	< Teacher >
Description	<Will be able to check the progress of the student>
Trigger	<Completion of the game>
Pre-conditions	<That the student has completed the game atleast once> 
Post-conditions	<Able to see the progress of the student > 
Main Success Scenario	
1.	Check if the student has finished the game
2.	Check results of student
3.	If the results appear then the goal has been fulfiled
Extensions	If results do not appear
< Request student to play the game >
Priority	<High: display results)
Special Requirements	<none> 
Open Questions	<none>

UC-3	<Change Difficulty level> 
Primary Actor(s)	< student>
Description	<change between difficulty levels >
Trigger	<When user would like to be challeged or start from the lowest level>
Pre-conditions	<Default difficulty level: Easy, is active > 
Post-conditions	<Difficult level is not Easy> 
Main Success Scenario	
1.	<check if difficulty level is Easy, if it is then
2.	Change difficulty level to desired level
3.	New level is set: GOAL-ACHIEVED>
Extensions	If difficulty level is not Easy then
<Change difficulty level to desired difficulty leve>
Priority	<High: Difficulty level change)
Special Requirements	<none> 
Open Questions	<none>

UC-4 	<Group chat in game> 
Primary Actor(s)	< student and teacher >
Description	<students and teachers will be able to communicate and share ideas>
Trigger	<If the students and/or teacher would like to share ideas and solutions>
Pre-conditions	<No active group chat> 
Post-conditions	<Active group chat > 
Main Success Scenario	
1.	<check if group chat is active, if not
2.	invite users to join group chat
3.	Active group chat:  GOAL-ACHIEVED>
Extensions	If group chat is already active then
<Ignore request for a group new chat.>
Priority	<High: Active group chat)
Special Requirements	<none> 
Open Questions	<none>
                       
UC-5 	<Group game play> 
Primary Actor(s)	< Students >
Description	<Students can have play together in answering the questions>
Trigger	< If student would like to share a game and help each other >
Pre-conditions	<That there student/user is not on group play at that moment> 
Post-conditions	<You will have multiple player in one game > 
Main Success Scenario	
1.	<Check if student is on group play
2.	invite other students to play you want to share the game with
3.	If more than 1 student is in the same game then use case is fulfilled >
Extensions	If student is already in a group game
<ignore request for a group play)
Special Requirements	<none> 
Open Questions	<none>
                       
UC-6 	<Answering Questions> 
Primary Actor(s)	< students >
Description	<students have to provide answers to the question given>
Trigger	< when a question is asked >
Pre-conditions	< Question has been asked and has not been answered before > 
Post-conditions	< when answer is given by student > 
Main Success Scenario	
1.	Check if question has been asked, if not.
2.	Ask desired question
3.	When question is answered, then the goal hass been fulfilled>
Extensions	If question is not answered then
<Ask question again , give option to skip question or offer a clue. )
Special Requirements	<none> 
Open Questions	<none>                       

# Func. spec. : How it applies to the use cases
They will provide the guide lines as to how the game is supposed to function. 
