Feature: CricketGameFeature
	
@mytag
	Scenario: player1 and player2 are playing cricket with initial score as 0 and player1 wins
	
	Given player1 starts the game with initial score as  0
	And player1 scores 4 runs
	And player1 gets out
	And player1 total scores is 4
	Given player2 starts the game with initial score as  0
	And player2 scores 1 runs
	And player2 gets out
	And player2 total scores is 1
	When player1 scores is greater than player2 score 
	Then player1 wins set 1

	Scenario:  player1 and player2 are playing cricket with initial score as 0 and player2 wins

	Given player1 starts the game with initial score as  0
	And player1 scores 1 runs
	And player1 gets out
	And player1 total scores is 1
	Given player2 starts the game with initial score as  0
	And player2 scores 4 runs
	And player2 gets out
	And player2 total scores is 4
	When player2 scores is greater than player1 score 
	Then player2 wins set 1

	Scenario:  player1 and player2 are playing cricket with initial score as 0 and Tie occurs

	Given player1 starts the game with initial score as  0
	And player1 scores 4 runs
	And player1 gets out
	And player1 total scores is 4
	Given player2 starts the game with initial score as  0
	And player2 scores 4 runs
	And player2 gets out
	And player2 total scores is 4
	When player2 scores is equal to player1 score 
	Then There should be a Tie



