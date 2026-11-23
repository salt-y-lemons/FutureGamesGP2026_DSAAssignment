 My experience with the assignment was a good learning experience I feel, it really felt like I was learning something that I would use in the future.

As for overcome challenges, there were some I don't recall and some I do, namely a misreading on my end, interpreting the binary search as a sorting algorithm, the solution was a bit of help by Jo and a removal of the unnecessary sorting algorithm.

In week 4 using the binary search algorithm I was able to sort out the employees by their ```LastEntranceInEngineRoom``` value. This was by using the ``DateTime.Parse`` Method to convert it to a comparable value for each employee and then compare them.

Week 5 was a bit differently paced than the others since, you had two options to implement into the code, hash maps and/or binary search trees, which I chose hash maps because I've heard they are useful for how data is stored and searched through efficiently.

The way I built it is that my script gets the employees from the computer file, and it can either, get the employee via the name as input or it's ``LastEntranceInEngineRoom`` value, and it does this by iterating over each employee in the JSON file and assigning it to the hash.

As for some problems I encountered during the assignment, it came up that I thought I had to set up a reference to the Computer's employee JSON file while it turns out that I just had to add the line ``using static Environment.Computer;`` so I could reference it's field instead because it was causing errors. Then there was a small pattern with the hash function which a classmate helped me fix which was that I was returning the module of the values hash code by 10 instead of it's length which you're supposed to.