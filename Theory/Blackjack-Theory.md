## Blackjack 2018 Theory Report - James Samios


#### Problem Definition:

The game blackjack is a very popular game. It is traditionally a card game, played with betting currency. The objective of the game is to either get 21 with an ace and a face card, or have the highest value at the end of the game without exceeding 21.

The problem is to create a Blackjack game for Windows. The solution is created in C#, utilising traditional game rules, but ensuring the game is always free, not making the users spend real money for bets. This is not a gambling game in the sense that the user can get anything financially in return.


#### Needs and Objectives:

The needs and objectives of Blackjack are pretty simple. The player should be able to hit and stand, there should be a dealer which stands at 17, and there should be at least 1 computer player (AI), maximum 3 for my project. The Graphical User Interface should be easy to use and ergonomic, and the player should be able to bet virtual money on the game which is completely free. The boundaries of the application entail the solution not being over complicated, such as a complex AI which thinks on its own, rather than just checking what number it is on and either hitting/standing depending on what number that is. Furthermore, keeping the same game rules is important so I do not branch off into another game of version which is not what the task entails. Some other boundaries include that the game cannot be played online, there is no betting function implemented, and no splitting or doubling hands was implemented.

#### Feasibility Report:

**Operational Feasibility**
I was able to get most of the requirements completed, in reasonable time. Some things I wasn't able to solve, however the application/game does follow most of the guidelines/required implemented functions. Overall, I believe that the application did follow the OOP (Object Oriented Programming) and the code was flexible enough to change for future developers.

**Scheduling Feasibility**
The time prescribed to complete this project has been seven weeks. This is more than enough time to get everything implemented. Overall, including other assessments and tasks, the time needed to complete the game was less than seven weeks, however having a large timeframe to complete the task has been a lot less stressful.

**Financial Feasibility**
The cost of making this application is nothing. As I'm building it myself, and not purchasing graphics or images, the cost is not foreseen through this project. There is in-game currency, which is free. There are no costs to purchase or play the game either.

**Technical Feasibility**
The application was developed in C#. I uploaded my project's major updates via Git, using my own GitLab server (https://git.samios.io). I am familiar with C#, as I have used it for other projects and it is a great beginner language to use. To create the theory, Atom was used for the text-based responses such as this one, and Adobe Photoshop CC 2018 was used to create the Data Flow Diagram and Dealer System Flowchart. Creating the application was enjoyable yet not too complicated, however I was not able to implement everything required before the due date.

#### Evaluation of Implementation Methodologies Report:

This report will outline the different Implementation methodologies, and concluding with the one I chose for my project. The four main methods are:

- Direct Cut-Over
- Parallel
- Phased
- Pilot

**Direct Cut-Over**
This involves instantly going to the new system. This is mainly used for new systems that did not have a predecessor system/software, or where a company/business wants to go directly to the new system not requiring any training or worries with the new and old systems. It is good because it is cheap, easier to manage, and is very quick. Some disadvantages are that the data must be converted, which can sometimes go wrong (Especially in Scots' Pipeline --> Synergetic scenario). Additionally, the users need to be trained, and if not, it can cause many issues such as service interruptions.

**Parallel**
This is similar to direct cut-over, except the old system is kept running for some time. This happened with Scots' Pipeline --> Synergetic move, however proper training and data conversion was not done right. This method is good as the users get used to using the new system, whilst can still use the old one to complete any tasks required, however can be costly to run and manage for the system administrators/developers/managers. 

**Phased**
The phased method is both similar to direct cut-over and parallel. However, the difference is that certain features are enabled/disabled respectively on the new and old system. For example, the server to upload files might be changed to the new one on the old system, or the ability to change your password is removed from the old system and added to the new one. The advantages of this is that no duplicate features are in both systems, and everyone eventually gets used to the new system. Some disadvantages are that it is hard to manage for system administrators/developers/managers and it can be costly.

**Pilot**
This method is similar to Phased, in the sense that certain features are implemented over a trial period of time. Advantages of this is that it provides a period of time that allows users to find any issues with the software/system, and these issues can be fixed easily in the next iteration of time period/trial. However, it can be expensive and difficult to manage.

**Chosen Method:**
For my system, I have chosen the direct cut-over method. I chose this because I am only developing it myself, and the previous system was a base code from Mr. Howse. There is no issue in converting data, as there practically isn't any, and there isn't a worry about budget or user base, as these are both non-existent for this project. This system doesn't necessarily replace the base code I was given, but is an adaptation.
