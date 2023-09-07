param(
[string]$target
)
$trace=tnc $target -TraceRoute
$count=[string]$trace.TraceRoute.Count
foreach ($ip in $trace.TraceRoute) {
$result=$result+$ip+" > "
}
$result=$result.Substring(0,$result.Length-3)
$message=$count+" hops to reach "+$target+" via "+$result
write-host $count":"$message