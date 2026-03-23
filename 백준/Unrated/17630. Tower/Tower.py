import sys

def solve():
    # 입력을 빠르게 읽기 위해 sys.stdin 사용
    input_data = sys.stdin.read().split()
    if not input_data:
        return
    
    T = int(input_data[0])
    results = []
    
    for t in range(1, T + 1):
        q = int(input_data[t])
        
        # q=1인 경우 별도 처리 (1단계: 범위 1 1)
        if q == 1:
            results.append("1\n1 1")
            continue
            
        # 2^(k-1) < q <= 2^k 인 k 찾기
        k = (q - 1).bit_length()
        
        # 합의 시퀀스 (S_1 to S_{k+1}) 생성
        s_list = [0] * (k + 2)
        s_list[k + 1] = q
        for i in range(k, 0, -1):
            s_list[i] = (s_list[i + 1] + 1) // 2
            
        # 단계별 l, u 저장
        steps = []
        for i in range(1, k + 1):
            a_next = s_list[i+1] - s_list[i]
            # S_{l-1} = S_i - a_next
            diff = s_list[i] - a_next
            l = 1 if diff == 0 else 2
            u = i
            steps.append(f"{l} {u}")
            
        # 마지막 단계: 지금까지의 모든 합(q)을 최상단에 추가
        steps.append(f"1 {k+1}")
        
        # 결과 정리
        res = [str(len(steps))] + steps
        results.append("\n".join(res))
        
    sys.stdout.write("\n".join(results) + "\n")

if __name__ == "__main__":
    solve()