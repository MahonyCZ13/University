Write-Host "Algoritmus: Euklides" -ForegroundColor Yellow

$x = 41224
$y = 22693

Write-Host "x = $x, y = $y"

while ($z -ne 0)
{
    $z = $x % $y
    Write-Verbose "$x % $y = $z"
    $x = $y - $z
    Write-Verbose "$y - $z = $x"
    if ($z -eq 0)
    {
        Write-Host("NSD je:", $y) -ForegroundColor Green
        break
    }
    else
    {
        $y = $z
    }
    Write-Verbose "y = $y"
    Write-Verbose "--------"
}