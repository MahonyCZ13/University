<!DOCTYPE html>
<html>
	<head>
		<meta http-equiv="Content-Type" content="text/html;charset=UTF-8">
		<title>Arktida</title>
		<link rel="stylesheet" href="styles.css" >
	</head>
	<body>
		<h1 class="titulek">Úvod</h1>
		<h2>Co je to vlastně Arktida</h2>
		<p>Arktida je název pro polární oblast okolo severního pólu. Název pochází z řeckého αρκτος (arktos) – medvěd a vztahuje se k souhvězdí Velká Medvědice a Malého Medvěda v blízkosti severního nebeského pólu. Oblast je tvořená Severním ledovým oceánem pokrytým mořským ledem, který každoročně částečně roztává a rozpadá se na plovoucí kry, a severními oblastmi a ostrovy Ruska, Kanady, USA a skandinávských zemí (včetně Grónska), kde jsou oblasti ledovců, věčně zmrzlé půdy a tundry. Na rozdíl od Antarktidy v okolí jižního pólu není Arktida světadílem. Polární oblasti představují specifický biotop. Typickým arktickým endemitním zvířetem je lední medvěd, naopak zde nežijí antarktičtí tučňáci.<sup><a href="#reference1">[1]</a></sup></p>
		<?php 
            $link = mysqli_connect('localhost', 'root', '', 'arktida');
            if (!$link) {
                die('Could not connect: ' . mysqli_error());
            }
            else {
                echo 'Connected successfully'.'<br>';
            }
            
            $sql = "SELECT * FROM `mesta`";
            $result = mysqli_query($link, $sql);
            
            if (mysqli_num_rows($result) > 0) {
                while($row = mysqli_fetch_assoc($result))
                {
                    $temp = (int)$row['temp'];
                    echo 'ID: ' . $row["mid"] . ' Mesto: ' . $row["nazev"] . ' temp: ' . $temp . '<br>';
                }
            }
            else
            {
                echo '0 vysledku';
            }
            mysqli_close($link);
        ?>
        <h2>Detailní pohled</h2>
			<table cellspacing="0">
			<tr>
			<td class="levo">
				<h3>Ekosystém</h3>
				<p>V současné době je ekosystém Arktidy velice křehký a díky roustoucím teplotám jak oceánu, tak vzduchu čelí mnoha nebezpečím.</p>
			</td>
			<td class="stred">
				<h3>Človek</h3>
				<p>Již není pochyb, že člověk má na planetu reálný dopad. Arktida je zatím nejohroženější biom na světě.</p>
			</td>
			<td class="pravo">
				<h3>Budoucnost</h3>
				<p>Budoucnost Arktidy je dnes velkým otazníkem.</p>
			</td>
			</tr>
			<tr>
			<td class="obrazek">
				<img src="tundra.jpg" alt="Tundra v Arktide" width="200px">
			</td>
			<td class="obrazek">
				<img src="house.jpg" alt="Dum na Lofotech" width="250px">
			</td>
			<td class="obrazek">
				<img src="ice.jpg" alt="Led na Svalbardu" width="200px">
			</td>
			</tr>
		</table>
		<hr>
		<h4>Seznam referencí</h4>
		<ul>
			<li id="reference1">[1] <a href="https://cs.wikipedia.org/wiki/Arktida">Arktida - Wikipedia</a></li>
		</ul>
	</body>
</html>
