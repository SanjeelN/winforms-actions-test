Get-TimeZone | Format-List
Get-Process | Where-Object {$_.CPU -gt 100}
Get-ChildItem -Path $HOME -Recurse | Where-Object {$_.Length -gt 500MB} | Select-Object FullName, Length | Sort-Object Length -Descending | Format-Table -AutoSize