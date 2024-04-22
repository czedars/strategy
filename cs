<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Tablice HTML</title>
    <style>
        table {
            border-collapse: collapse;
            width: 100%;
        }

        table,
        th,
        td {
            border: 1px solid black;
            padding: 8px;
            text-align: center;
        }

        th {
            background-color: lightgray;
        }
    </style>
</head>

<body>

    <table>
        <caption>Rough Strategy</caption>
        <tr>
            <th rowspan="2">tyres</th>
            <th rowspan="2">fuel / km</th>
            <th rowspan="2">fuel / lap</th>
            <th rowspan="2">tyres / km</th>
            <th rowspan="2">tyres / lap</th>
            <th colspan="4">stint</th>

            <th rowspan="2">pitstops</th>
            <th colspan="4">time loss</th>

            <th>time gain</th>
            <th rowspan="2">total</th>
        </tr>
        <tr>
            <th>km</th>
            <th>laps</th>
            <th>fuel</th>
            <th>tyres</th>
            <th>pits</th>
            <th>fuel load</th>
            <th>TCD</th>
            <th>tyres wear</th>
            <th>CT gain</th>
        </tr>
        <tr>
            <td>extra soft</td>
            <td>dry_fuel_per_km</td>
            <td>dry_fuel_per_lap</td>
            <td id="xs_tyres_per_km">xs_tyres_per_km</td>
            <td id="xs_tyres_per_lap">xs_tyres_per_lap</td>
            <td id="xs_stint_km">xs_stint_km</td>
            <td id="XS_laps">XS_laps</td>
            <td id="xs_stint_fuel">xs_stint_fuel</td>
            <td id="xs_stint_tyres">xs_stint_tyres</td>
            <td>
                <select id="xsPitsSelect" onchange="updateXsPits()">
                    <!-- Opcje menu -->
                    <option value="0">0</option>
                    <option value="1">1</option>
                    <option value="2">2</option>
                    <option value="3">3</option>
                    <option value="4">4</option>
                    <option value="5">5</option>
                    <option value="6">6</option>
                </select>
            </td>
            <td>Wiersz 11</td>
            <td>Wiersz 12</td>
            <td>Wiersz 13</td>
            <td>Wiersz 14</td>
            <td>Wiersz 15</td>
            <td>Wiersz 16</td>
        </tr>
        <tr>
            <td>soft</td>
            <td>dry_fuel_per_km</td>
            <td>dry_fuel_per_lap</td>
            <td id="soft_tyres_per_km">soft_tyres_per_km</td>
            <td id="soft_tyres_per_lap">soft_tyres_per_lap</td>
            <td id="soft_stint_km">soft_stint_km</td>
            <td id="Soft_laps">Soft_laps</td>
            <td id="soft_stint_fuel">soft_stint_fuel</td>
            <td id="soft_stint_tyres">soft_stint_tyres</td>
            <td>
                <select id="softPitsSelect" onchange="updateSoftPits()">
                    <!-- Opcje menu -->
                    <option value="0">0</option>
                    <option value="1">1</option>
                    <option value="2">2</option>
                    <option value="3">3</option>
                    <option value="4">4</option>
                    <option value="5">5</option>
                    <option value="6">6</option>
                </select>
            </td>
            <td>Wiersz 11</td>
            <td>Wiersz 12</td>
            <td>Wiersz 13</td>
            <td>Wiersz 14</td>
            <td>Wiersz 15</td>
            <td>Wiersz 16</td>
        </tr>
        <tr>
            <td>medium</td>
            <td>dry_fuel_per_km</td>
            <td>dry_fuel_per_lap</td>
            <td id="medium_tyres_per_km">medium_tyres_per_km</td>
            <td id="medium_tyres_per_lap">medium_tyres_per_lap</td>
            <td id="medium_stint_km">medium_stint_km</td>
            <td id="Medium_laps">Medium_laps</td>
            <td id="medium_stint_fuel">medium_stint_fuel</td>
            <td id="medium_stint_tyres">medium_stint_tyres</td>
            <td>
                <select id="mediumPitsSelect" onchange="updateMediumPits()">
                    <!-- Opcje menu -->
                    <option value="0">0</option>
                    <option value="1">1</option>
                    <option value="2">2</option>
                    <option value="3">3</option>
                    <option value="4">4</option>
                    <option value="5">5</option>
                    <option value="6">6</option>
                </select>
            </td>
            <td>Wiersz 11</td>
            <td>Wiersz 12</td>
            <td>Wiersz 13</td>
            <td>Wiersz 14</td>
            <td>Wiersz 15</td>
            <td>Wiersz 16</td>
        </tr>
        <tr>
            <td>hard</td>
            <td>dry_fuel_per_km</td>
            <td>dry_fuel_per_lap</td>
            <td id="hard_tyres_per_km">hard_tyres_per_km</td>
            <td id="hard_tyres_per_lap">hard_tyres_per_lap</td>
            <td id="hard_stint_km">hard_stint_km</td>
            <td id="Hard_laps">Hard_laps</td>
            <td id="hard_stint_fuel">hard_stint_fuel</td>
            <td id="hard_stint_tyres">hard_stint_tyres</td>
            <td>
                <select id="hardPitsSelect" onchange="updateHardPits()">
                    <!-- Opcje menu -->
                    <option value="0">0</option>
                    <option value="1">1</option>
                    <option value="2">2</option>
                    <option value="3">3</option>
                    <option value="4">4</option>
                    <option value="5">5</option>
                    <option value="6">6</option>
                </select>
            </td>
            <td>Wiersz 11</td>
            <td>Wiersz 12</td>
            <td>Wiersz 13</td>
            <td>Wiersz 14</td>
            <td>Wiersz 15</td>
            <td>Wiersz 16</td>
        </tr>
        <tr>
            <td>rain</td>
            <td id="rain_fuel_per_km">rain_fuel_per_km</td>
            <td id="rain_fuel_per_lap">rain_fuel_per_lap</td>
            <td id="rain_tyres_per_km">rain_tyres_per_km</td>
            <td id="rain_tyres_per_lap">rain_tyres_per_lap</td>
            <td id="rain_stint_km">rain_stint_km</td>
            <td id="Rain_laps">Rain_laps</td>
            <td id="rain_stint_fuel">rain_stint_fuel</td>
            <td id="rain_stint_tyres">rain_stint_tyres</td>
            <td>
                <select id="rainPitsSelect" onchange="updateRainPits()">
                    <!-- Opcje menu -->
                    <option value="0">0</option>
                    <option value="1">1</option>
                    <option value="2">2</option>
                    <option value="3">3</option>
                    <option value="4">4</option>
                    <option value="5">5</option>
                    <option value="6">6</option>
                </select>
            </td>
            <td>Wiersz 11</td>
            <td>Wiersz 12</td>
            <td>Wiersz 13</td>
            <td>Wiersz 14</td>
            <td>Wiersz 15</td>
            <td>Wiersz 16</td>
        </tr>
    </table>
    <script>
        var lap_length = 4.42
        var laps = 69
        var dry_fuel_per_km = 0.662;
        var rain_fuel_per_km = 0.516;
        var xs_tyres_per_km = 0.790;
        var soft_tyres_per_km = 0.601;
        var medium_tyres_per_km = 0.470;
        var hard_tyres_per_km = 0.369;
        var rain_tyres_per_km = 0.199;
        var dry_fuel_per_lap = (lap_length * dry_fuel_per_km).toFixed(3)
        var rain_fuel_per_lap = (lap_length * rain_fuel_per_km).toFixed(3)
        var xs_tyres_per_lap = (lap_length * xs_tyres_per_km).toFixed(3)
        var soft_tyres_per_lap = (lap_length * soft_tyres_per_km).toFixed(3)
        var medium_tyres_per_lap = (lap_length * medium_tyres_per_km).toFixed(3)
        var hard_tyres_per_lap = (lap_length * hard_tyres_per_km).toFixed(3)
        var rain_tyres_per_lap = (lap_length * rain_tyres_per_km).toFixed(3)

        var cells = document.getElementsByTagName("td");
        for (var i = 0; i < cells.length; i++) {
            if (cells[i].innerHTML === "dry_fuel_per_km") {
                cells[i].innerHTML = dry_fuel_per_km;
            }
        }
        for (var i = 0; i < cells.length; i++) {
            if (cells[i].innerHTML === "dry_fuel_per_lap") {
                cells[i].innerHTML = dry_fuel_per_lap;
            }
        }
        document.getElementById('rain_fuel_per_km').innerHTML = rain_fuel_per_km;
        document.getElementById('rain_fuel_per_lap').innerHTML = rain_fuel_per_lap;
        document.getElementById('xs_tyres_per_km').innerHTML = xs_tyres_per_km;
        document.getElementById('soft_tyres_per_km').innerHTML = soft_tyres_per_km;
        document.getElementById('medium_tyres_per_km').innerHTML = medium_tyres_per_km;
        document.getElementById('hard_tyres_per_km').innerHTML = hard_tyres_per_km;
        document.getElementById('rain_tyres_per_km').innerHTML = rain_tyres_per_km;
        document.getElementById('xs_tyres_per_lap').innerHTML = xs_tyres_per_lap;
        document.getElementById('soft_tyres_per_lap').innerHTML = soft_tyres_per_lap;
        document.getElementById('medium_tyres_per_lap').innerHTML = medium_tyres_per_lap;
        document.getElementById('hard_tyres_per_lap').innerHTML = hard_tyres_per_lap;
        document.getElementById('rain_tyres_per_lap').innerHTML = rain_tyres_per_lap;

        function updateXsPits() {
            var xsPitsSelect = document.getElementById("xsPitsSelect");
            var selectedValue = xsPitsSelect.value;
            window.XS_pits = parseInt(selectedValue); // Zapisz wybraną wartość jako liczbę do zmiennej XS_pits
            updateXsLaps(); // Wywołaj funkcję aktualizującą zmienne zależne od XS_pits
        }

        function updateXsLaps() {
            var xs_laps = laps / (window.XS_pits + 1);
            xs_laps = Math.ceil(xs_laps); // Zaokrąglanie w górę
            console.log("XS_laps: ", xs_laps);
            document.getElementById('XS_laps').innerHTML = xs_laps;
            var xs_stint_km = (lap_length * xs_laps).toFixed(1);
            console.log(xs_stint_km);
            document.getElementById('xs_stint_km').innerHTML = xs_stint_km;
            var xs_stint_fuel = dry_fuel_per_km * xs_stint_km;
            xs_stint_fuel = Math.ceil(xs_stint_fuel); // Zaokrąglanie w górę
            document.getElementById('xs_stint_fuel').innerHTML = xs_stint_fuel;
            var xs_stint_tyres = xs_tyres_per_km * xs_stint_km;
            xs_stint_tyres = Math.ceil(xs_stint_tyres); // Zaokrąglanie w górę
            document.getElementById('xs_stint_tyres').innerHTML = xs_stint_tyres + "%";
        }

        function updateSoftPits() {
            var softPitsSelect = document.getElementById("softPitsSelect");
            var selectedValue = softPitsSelect.value;
            window.Soft_pits = parseInt(selectedValue); // Zapisz wybraną wartość jako liczbę do zmiennej XS_pits
            updateSoftLaps(); // Wywołaj funkcję aktualizującą zmienne zależne od XS_pits
        }

        function updateSoftLaps() {
            var soft_laps = laps / (window.Soft_pits + 1);
            soft_laps = Math.ceil(soft_laps); // Zaokrąglanie w górę
            console.log("Soft_laps: ", soft_laps);
            document.getElementById('Soft_laps').innerHTML = soft_laps;
            var soft_stint_km = (lap_length * soft_laps).toFixed(1);
            console.log(soft_stint_km);
            document.getElementById('soft_stint_km').innerHTML = soft_stint_km;
            var soft_stint_fuel = dry_fuel_per_km * soft_stint_km;
            soft_stint_fuel = Math.ceil(soft_stint_fuel); // Zaokrąglanie w górę
            document.getElementById('soft_stint_fuel').innerHTML = soft_stint_fuel;
            var soft_stint_tyres = soft_tyres_per_km * soft_stint_km;
            soft_stint_tyres = Math.ceil(soft_stint_tyres); // Zaokrąglanie w górę
            document.getElementById('soft_stint_tyres').innerHTML = soft_stint_tyres + "%";
        }

        function updateMediumPits() {
            var mediumPitsSelect = document.getElementById("mediumPitsSelect");
            var selectedValue = mediumPitsSelect.value;
            window.Medium_pits = parseInt(selectedValue); // Zapisz wybraną wartość jako liczbę do zmiennej XS_pits
            updateMediumLaps(); // Wywołaj funkcję aktualizującą zmienne zależne od XS_pits
        }

        function updateMediumLaps() {
            var medium_laps = laps / (window.Medium_pits + 1);
            medium_laps = Math.ceil(medium_laps); // Zaokrąglanie w górę
            console.log("Medium_laps: ", medium_laps);
            document.getElementById('Medium_laps').innerHTML = medium_laps;
            var medium_stint_km = (lap_length * medium_laps).toFixed(1);
            console.log(medium_stint_km);
            document.getElementById('medium_stint_km').innerHTML = medium_stint_km;
            var medium_stint_fuel = dry_fuel_per_km * medium_stint_km;
            medium_stint_fuel = Math.ceil(medium_stint_fuel); // Zaokrąglanie w górę
            document.getElementById('medium_stint_fuel').innerHTML = medium_stint_fuel;
            var medium_stint_tyres = medium_tyres_per_km * medium_stint_km;
            medium_stint_tyres = Math.ceil(medium_stint_tyres); // Zaokrąglanie w górę
            document.getElementById('medium_stint_tyres').innerHTML = medium_stint_tyres + "%";
        }
        function updateHardPits() {
            var hardPitsSelect = document.getElementById("hardPitsSelect");
            var selectedValue = hardPitsSelect.value;
            window.Hard_pits = parseInt(selectedValue); // Zapisz wybraną wartość jako liczbę do zmiennej XS_pits
            updateHardLaps(); // Wywołaj funkcję aktualizującą zmienne zależne od XS_pits
        }

        function updateHardLaps() {
            var hard_laps = laps / (window.Hard_pits + 1);
            hard_laps = Math.ceil(hard_laps); // Zaokrąglanie w górę
            console.log("Hard_laps: ", hard_laps);
            document.getElementById('Hard_laps').innerHTML = hard_laps;
            var hard_stint_km = (lap_length * hard_laps).toFixed(1);
            console.log(hard_stint_km);
            document.getElementById('hard_stint_km').innerHTML = hard_stint_km;
            var hard_stint_fuel = dry_fuel_per_km * hard_stint_km;
            hard_stint_fuel = Math.ceil(hard_stint_fuel); // Zaokrąglanie w górę
            document.getElementById('hard_stint_fuel').innerHTML = hard_stint_fuel;
            var hard_stint_tyres = hard_tyres_per_km * hard_stint_km;
            hard_stint_tyres = Math.ceil(hard_stint_tyres); // Zaokrąglanie w górę
            document.getElementById('hard_stint_tyres').innerHTML = hard_stint_tyres + "%";
        }

        function updateRainPits() {
            var rainPitsSelect = document.getElementById("rainPitsSelect");
            var selectedValue = rainPitsSelect.value;
            window.Rain_pits = parseInt(selectedValue); // Zapisz wybraną wartość jako liczbę do zmiennej XS_pits
            updateRainLaps(); // Wywołaj funkcję aktualizującą zmienne zależne od XS_pits
        }

        function updateRainLaps() {
            var rain_laps = laps / (window.Rain_pits + 1);
            rain_laps = Math.ceil(rain_laps); // Zaokrąglanie w górę
            console.log("rain_laps: ", rain_laps);
            document.getElementById('Rain_laps').innerHTML = rain_laps;
            var rain_stint_km = (lap_length * rain_laps).toFixed(1);
            console.log(rain_stint_km);
            document.getElementById('rain_stint_km').innerHTML = rain_stint_km;
            var rain_stint_fuel = dry_fuel_per_km * rain_stint_km;
            rain_stint_fuel = Math.ceil(rain_stint_fuel); // Zaokrąglanie w górę
            document.getElementById('rain_stint_fuel').innerHTML = rain_stint_fuel;
            var rain_stint_tyres = rain_tyres_per_km * rain_stint_km;
            rain_stint_tyres = Math.ceil(rain_stint_tyres); // Zaokrąglanie w górę
            document.getElementById('rain_stint_tyres').innerHTML = rain_stint_tyres + "%";
        }



        // Aktualizuj XS_laps po załadowaniu strony
        window.onload = function () {
            updateXsPits();
            updateSoftPits();
            updateMediumPits();
            updateHardPits();
            updateRainPits();
        };
    </script>
</body>

</html>
