using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections;
using System.Text.RegularExpressions;

				
					
public class TripleStep{
	int countWays(int n) {
		int[] memo = new int[n + 1];
		//Array.fill(memo, -1);
		memo= Enumerable.Repeat(-1, n+1).ToArray();
		return countWays(n, memo);

 	}

	int countWays(int n, int[] memo) {

		if (n < 0) {
			return 0;

		} else if (n == 0) {

			return 1;


		} else if (memo[n] > -1) {
			return memo[n];


		} else {

			memo[n] = countWays(n - 1, memo)+ countWays(n - 2, memo)+ countWays ( n - 3, memo) ;

			return memo[n];

 		}
	}

	
	public void Main(){
	
	 	var n = countWays(3);
		Console.WriteLine("The result of Triple Step Algorithm is : ");
		Console.WriteLine(n); 
	}
}
