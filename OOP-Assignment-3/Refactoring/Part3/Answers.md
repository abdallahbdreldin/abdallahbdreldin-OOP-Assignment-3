# Part 03 — answers

---

## BlockedUsers

	- Time complexity before: o(n)2
	- Time (ms) before: 43 ms
	- What did you change? using a hashset to store the blocked users instead of a list
	- Time complexity after: o(n)
	- Time (ms) after: 0 ms

---

## Students

	- What was the problem? loading all 1_000_000 students into memory at once
	- What did you change? using yield return to load students one at a time instead of all at once
