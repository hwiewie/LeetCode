class Solution:
def reverseVowels(self, s):
"""
:type s: str
:rtype: str
"""
# 相當於一個有限制的字串逆序，只對字串中的母音字母進行逆序。
# Approach #1
# vowels = ('a','e','i','o','u','A','E','I','O','U')
# ss = [i for i in s if i in vowels]
# return ''.join([ss.pop() if i in vowels else i for i in list(s)  ])
# Approach #2
import re
ss = re.findall('[aeiouAEIOU]',s)
return re.sub('[aeiouAEIOU]',lambda m: ss.pop() ,s)
# Approach #3
# import re
# return re.sub('(?i)[aeiou]', lambda m, v=re.findall('(?i)[aeiou]', s): v.pop(), s)