

def parity(x: int) -> bool:
	odds_seen = 0
	while (x):
		if x & 1 == 1:
			odds_seen += 1
		x >>= 1

	return (odds_seen % 2)

def parity_solution(x: int) -> bool:
	result = 0
	while x:
		result ^= x & 1
		x >>= 1
	return result

if __name__ == "__main__":
	print(parity(1))
	print(parity(2))
	print(parity(3))
	print(parity(6))
	print(parity(100))
	print(parity(101))
	print('\n')
	print(parity_solution(1))
	print(parity_solution(2))
	print(parity_solution(3))
	print(parity_solution(6))
	print(parity_solution(100))
	print(parity_solution(101))


  