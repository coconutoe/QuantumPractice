// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license.

namespace Quantum.Kata.GHZGame {

    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Math;
    open Microsoft.Quantum.Intrinsic;
    open Microsoft.Quantum.Diagnostics;

    //////////////////////////////////////////////////////////////////
    // Welcome!
    //////////////////////////////////////////////////////////////////

    // The "GHZ Game" quantum kata is a series of exercises designed
    // to get you familiar with the GHZ game.

    // In it three players (Alice, Bob and Charlie) try to win the
    // following game:

    // Each of them is given a bit (r, s and t respectively), and
    // they have to return new bits (a, b and c respectively) so
    // that  r ∨ s ∨ t = a ⊕ b ⊕ c. The input bits will have 
    // zero or two bits set to true and three or one bits set to false.
    // The trick is, the players can not communicate during the game.

    // Each task is wrapped in one operation preceded by the
    // description of the task. Each task has a unit test associated
    // with it, which initially fails. Your goal is to fill in the
    // blank (marked with // ... comment) with some Q# code to make
    // the failing test pass.


    //////////////////////////////////////////////////////////////////
    // Part I. Classical GHZ
    //////////////////////////////////////////////////////////////////

    // Task 1.1. Win condition
    // Input:
    //     1) Alice, Bob and Charlie's input bits (r, s and t), stored as an array of length 3,
    //     2) Alice, Bob and Charlie's output bits (a, b and c), stored as an array of length 3.
    // The input bits will have zero or two bits set to true.
    // Output:
    //     True if Alice, Bob and Charlie won the GHZ game, that is, if r ∨ s ∨ t = a ⊕ b ⊕ c,
    //     and false otherwise.
    function WinCondition (rst : Bool[], abc : Bool[]) : Bool {
		//let r = rst[0];
		//let s = rst[1];
		//let t = rst[2];
		let a = abc[0];
		let b = abc[1];
		let c = abc[2];
        if(not rst[0] and not rst[1] and not rst[2]) {
			if((not a and not b and not c) or (a and b and not c) or (a and not b and c) or (not a and b and c)) {
				return true;
			} else {
				return false;
			}
		} else {
			if((not a and not b and c) or (not a and b and not c) or (a and not b and not c) or (a and b and c)) {
				return true;
			} else {
				return false;
			}
		}
    }


    // Task 1.2. Random classical strategy
    // Input: The input bit for one of the players (r, s or t).
    // Output: A random bit that this player will output (a, b or c).
    // If all players use this strategy, they will win about 50% of the time.
    operation RandomClassicalStrategy (input : Bool) : Bool {
		let randNum = RandomInt(2);
        return randNum == 0;
    }


    // Task 1.3. Best classical strategy
    // Input: The input bit for one of the players (r, s or t).
    // Output: A bit that this player will output (a, b or c) to maximize their chance of winning. 
    // All players will use the same strategy.
    // The best classical strategy should win about 75% of the time.
    operation BestClassicalStrategy (input : Bool) : Bool {
        return true;
    }


    // Task 1.4. Referee classical GHZ game
    // Inputs:
    //      1) an operation which implements a classical strategy 
    //         (i.e., takes an input bit and produces and output bit),
    //      2) an array of 3 input bits that should be passed to the players.
    // Output:
    //      An array of 3 bits that will be produced if each player uses this strategy.
    operation PlayClassicalGHZ (strategy : (Bool => Bool), inputs : Bool[]) : Bool[] {
		if (not strategy(false)) {
			if (strategy(true)) {
				return inputs;
			} else {
				return [false, false, false];
			}
		} else {
			if (strategy(true)) {
				return [true, true, true];
			} else {
				return [not inputs[0], not inputs[1], not inputs[2]];
			}
		}

    }


    //////////////////////////////////////////////////////////////////
    // Part II. Quantum GHZ
    //////////////////////////////////////////////////////////////////

    // In the quantum version of the game, the players still can not
    // communicate during the game, but they are allowed to share 
    // qubits from an entangled triple before the start of the game.

    // Task 2.1. Entangled triple
    // Input: An array of three qubits in the |000⟩ state.
    // Goal: Create the entangled state |ψ⟩ = (|000⟩ - |011⟩ - |101⟩ - |110⟩) / 2 on these qubits.
    operation CreateEntangledTriple (qs : Qubit[]) : Unit {
        X(qs[2]);
		H(qs[1]);
		H(qs[0]);
		CNOT(qs[0], qs[2]);
		CNOT(qs[1], qs[2]);
		Z(qs[2]);
		H(qs[1]);
		H(qs[0]);
		CNOT(qs[2], qs[1]);

    }


    // Task 2.2. Quantum strategy
    // Inputs:
    //     1) The input bit for one of the players (r, s or t),
    //     2) That player's qubit of the entangled triple shared between the players.
    // Goal:  Measure the qubit in the Z basis if the bit is 0 (false),
    //        or the X basis if the bit is 1 (true), and return the result.
    // The state of the qubit after the operation does not matter.
    operation QuantumStrategy (input : Bool, qubit : Qubit) : Bool {
		mutable res = false;
        if (not input) {
			set res = M(qubit) == One;
		} else {
			Ry(PI()/-2.0, qubit);
			set res = M(qubit) == One;
		}
		return res;
    }


    // Task 2.3. Play the GHZ game using the quantum strategy
    // Input: Operations that return Alice, Bob and Charlie's output bits (a, b and c) based on
    //        their quantum strategies and given their respective qubits from the entangled triple. 
    //        The players have already been told what their starting bits (r, s and t) are.
    // Goal:  Return an array of players' output bits (a, b and c).
    //
    // Note that this task uses QuantumStrategy which you've implemented in task 2.2.
    operation PlayQuantumGHZ (strategies : (Qubit => Bool)[]) : Bool[] {
        using(qs = Qubit[3]) {
			CreateEntangledTriple(qs);
			let ret_abc = [strategies[0](qs[0]), strategies[1](qs[1]), strategies[2](qs[2])];
			ResetAll(qs);
			
			return ret_abc;
		}
        
    }
}
