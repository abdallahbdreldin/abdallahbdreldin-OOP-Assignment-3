# Part 02 — answers

---

## Reports

- What was the problem? duplicate code in the reports class
- What did you change? created report export bsae class that that contains the common code and just make the foramt steps abstract so that each report can implement it
- Why did you choose that approach? to follow the DRY (Don't Repeat Yourself) principle and make the code more maintainable

---

## Enrollment

- What was the problem? program.cs was responsible for createing the enrollment login in correcr order 
- What did you change? used the facade pattern to create a single entry point for the enrollment process
- Why did you choose that approach? to handl the complexity of the enrollment process and make it easier to use
