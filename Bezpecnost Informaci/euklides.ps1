Write-Host "Algoritmus: Euklides"

$x = 13400
$y = 656

Write-Host "x = $x, y = $y"

while ($z -ne 0)
{
    $z = $x % $y
    Write-Verbose "$x % $y = $z"
    $x = $y - $z
    Write-Verbose "$y - $z =  $x"
    if ($z -eq 0)
    {
        $z = $y
        break
    }
    else
    {
        $y = $z
    }
    Write-Verbose "y = $y"
    Write-Verbose "--------"
}
Write-Host("NSD je:", $z)
