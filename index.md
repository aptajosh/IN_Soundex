### Welcome To IN_Soundex
This project is created for generating soundex for Indian Names. There are many other variations of soundex algorithm already exists. Unfortunately, none of them works well with Indian Names.

### Problem With Existing Soundex Variations
Most of the other implementations of soundex finds and removes vowels(a,e,i,o,u,s) in their first step. But what I thought is these vowels or combination of vowels shape the sound of a letter.
### Solution
In this implementation, occurrences of a,e,i,o,u,s or combination of vowels replaced(not removed) first with some character or numeric constant. All the letters or combination of letters(substrings) replaced or tokenized in this approach are with consideration of Indian Names only. Therefore, it will work with Indian names in first place.
