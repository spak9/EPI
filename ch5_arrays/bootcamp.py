"""
Q: Given an array of integers, reorder the entries such that all even numbers appear first,
	w/o using O(n) space.

	[1,2,3,4,5] ==> [2,4,1,3,5]

A: arrays have efficient updates/reads on each end. Partition array into 3 classes: even, unclassified, odd,
	therefore the "even" class just needs to have the property of "even", not based on magnitude property
"""
from typing import List

def evens_first(array: List[int]) -> None:
	# indices on opposite sides
	next_even, next_odd = 0, len(array) - 1

	# loop until they meet (fully partitioned)
	while next_even < next_odd:

		# even
		if array[next_even] % 2 == 0:
			next_even += 1

		# odd 
		else:
			# swap ints, knowing that we've added one to the "odds"
			array[next_even], array[next_odd] = array[next_odd], array[next_even]
			next_odd -= 1


if __name__ == "__main__":
	a = [1,2,3,4,5] 
	evens_first(a)
	print(a)

