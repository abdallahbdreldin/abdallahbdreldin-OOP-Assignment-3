# Part 01 — answers

---

## ShippingCostCalculator

- What was the problem? ShippingCostCalculator used switch statements so if we added a new carrier we would have to edit the class.
- What did you change? created an interface thar carriers can implement , so we can add new carriers without editiing the existing class.

---

## OrderProcessor

- What was the problem? orderprocess was tightly coupled on sqlorder to save and smtp to send emails
- What did you change? depend on abstractions instead of concreate classess

---

## Notifications

- What was the problem? inheritance was used so if we added a new notification channel or even a new combination of channels we would have to edit the class.
- What did you change? change the inheritance to composition so we can add new notification channels without editiing the existing class.

---

## Proof

- New carrier file(s): UPSShippingCostCalculator
- New notification channel file(s): pushnotification
- Existing classes left unchanged? (yes/no): yes
