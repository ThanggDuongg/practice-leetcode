func sortVowels(s string) string {
    var isVowels [128]bool
    for _, v := range "aeiouAEIOU" {
        isVowels[v] = true
    }

    var vowelList []byte
    for i := 0; i < len(s); i++ {
        if isVowels[s[i]] {
            vowelList = append(vowelList, s[i])
        }
    }
    
    sort.Slice(vowelList, func(i, j int) bool { return vowelList[i] < vowelList[j] })
    var res strings.Builder
    j := 0
    for i := 0; i < len(s); i++ {
        if isVowels[s[i]] {
            res.WriteByte(vowelList[j])
            j++
        } else {
            res.WriteByte(s[i])
        }
    }

    return res.String()
}