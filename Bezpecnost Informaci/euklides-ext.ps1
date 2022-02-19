Write-Host "Algoritmus: Euklides - Rozsireny" -ForegroundColor Yellow
$x = 1
$y = 1
$a = 35
$b = 15

Write-Host "a = $a, b = $b, x = $x, y = $y"

function euklidExt {
    param (
        [int] $a, [int] $b, [int] $x, [int] $y
    )
    if($a -eq 0)
    {
        $x = 0
        $y = 1
        Write-Host "NSD = $b" -ForegroundColor Green
        break
    }

    $x1 = 1
    $y1 = 1
    $ba = $b % $a
    $nsd = euklidExt $ba $a $x1 $y1

    $x = $y1 - ($b / $a) * $x1
    $y = $x1

    Write-Host $nsd -ForegroundColor Green
}

euklidExt $a $b $x $y