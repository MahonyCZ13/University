<!DOCTYPE html>
<html>
	<head>
		<meta http-equiv="Content-Type" content="text/html;charset=UTF-8">
		<title>Arktida</title>
		<link rel="stylesheet" href="styles.css" >
	</head>
	<body>
		<?php error_reporting (E_ALL ^ E_NOTICE); ?> 
        <?php 
            /*
            DONE: Dropdown bude filtrovat tabulku
			DONE: Ukládat data do databáze
            */
            $conn = mysqli_connect('localhost', 'root', '', 'arktida');
            if (!$conn) {
                die('Could not connect: ' . mysqli_error());
            }
                        
            $sql = "SELECT cid, nazev FROM staty ";
            $result1 = mysqli_query($conn, $sql);
        ?>
		<h1 class="titulek">Průměrná roční teplota v severských městech</h1>
		<form method="GET" action="mesta.php">
			<select name="mesto-select" value="">
				<?php           
					while($row = mysqli_fetch_assoc($result1))
					{
				?>
				<option value="<?php echo $row["cid"] ?>" name="mesto"><?php echo $row["nazev"] ?></option>
				<?php 
					}
				?>
			</select>
			<button type="submit" name="filter">Filtruj</button>
		</form>
		<br />       
		<table class="mesta" cellspacing="0">
			<tr>
                <th class="mesta-hlava">ID města</th>
				<th class="mesta-hlava">Stát</th>
				<th class="mesta-hlava">Město</th>
				<th class="mesta-hlava">Průměrná teplota</th>
			</tr>
			<?php				
				if($_GET["mesto-select"] != "")
				{
					$cid = $_GET["mesto-select"];
				}
				else
				{
					$cid = 1;
				}
			?>
			<script type="text/javascript">
				var test = "mnam";
				var cid = <?php echo $cid; ?>;
				console.log(cid);
				alert(test);
			</script>
			<?php	    
                $sql2 = "SELECT staty.nazev AS stat, mesta.mid, mesta.nazev AS mesto, mesta.temp FROM mesta INNER JOIN staty ON (staty.cid = mesta.cid) WHERE mesta.cid = " . $cid . ";";
                $result2 = mysqli_query($conn, $sql2);
				while($row = mysqli_fetch_assoc($result2))
				{
					
					$temp = (int)$row['temp']; ?>				
					<tr>
                        <td class="mesta-data"><?php echo $row["mid"] ?></td>
						<td class="mesta-data"><?php echo $row["stat"] ?></td>
						<td class="mesta-data"><?php echo $row["mesto"] ?></td>
						<td class="mesta-data"><?php echo $temp ?>°C</td>
					</tr>
			<?php
				}						
				$sql3 = "SELECT cid, nazev FROM staty ";
            	$result3 = mysqli_query($conn, $sql3);
			?>
		</table>
		<h2>Přidejte si své vlastní město</h2>
		<form method="POST" action="mesta.php">
			<table>
				<tr>
					<td>Kód státu:</td>
					<td>
						<select name="kod-statu">
						<?php           
							while($row = mysqli_fetch_assoc($result3))
							{
						?>
								<option value="<?php echo $row["cid"] ?>" name="stkod"><?php echo $row["nazev"] ?></option>
						<?php 
							}
							mysqli_close($conn);
						?>
						</select>
					</td>
				</tr>
				<tr>
					<td>Název města:</td>
					<td><input type="text" name="nazev-mesta"/></td>
				</tr>
				<tr>
					<td>Rozloha: </td>
					<td><input type="number" name="rozloha-mesta"/></td>
				</tr>				
				<tr>
					<td>Obyvatelstvo:</td>
					<td><input type="number" name="pocet-obyvatel"/></td>
				</tr>
				<tr>
					<td>Teplota:</td>
					<td><input type="number" name="prumerna-templota"/></td>
				</tr>
				<tr>
					<td><br /><button type="submit" name="uloz">Ulož město</button></td>
				</tr>
			</table>
		</form>
		<?php
			//$nove_cid = (int)$_POST["kod-statu"];
			$conn = mysqli_connect('localhost', 'root', '', 'arktida');
			if (!$conn) {
				die('Could not connect: ' . mysqli_error());
			}
						
			$sql4 = "INSERT INTO mesta (cid, nazev, rozloha, obyvatele, temp) VALUES (". $_POST["kod-statu"] . ", '" . $_POST["nazev-mesta"] . "', " . $_POST["rozloha-mesta"] . ", " . $_POST["pocet-obyvatel"] . ", " . $_POST["prumerna-templota"] . ")";
			if($_POST["kod-statu"] != "")
			{
				if ($conn->query($sql4) === TRUE) {
					echo '<p class="db-status">Záznam byl uložen!</p>';
				  } else {
					echo '<p class="db-error">Error: ' . $sql4 . '<br>' . $conn->error . '</p>';
				  }
			}			
			mysqli_close($conn);
		?>
	</body>
</html>
