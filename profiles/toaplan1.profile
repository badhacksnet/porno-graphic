<?xml version="1.0" encoding="utf-8"?>
<profile:profile name="Toaplan Hardware (1988-1991)"
    xsi:schemaLocation="http://baddesthacks.net/porno-graphic/profile profile.xsd"
    xmlns:profile="http://baddesthacks.net/porno-graphic/profile"
    xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
>
	<layouts>
		<layout name="Tiles">
			<plane>
				<offset bits="8" fracnum="1" fracden="2" />
				<offset bits="0" fracnum="1" fracden="2" />
				<offset bits="8" />
				<offset bits="0" />
			</plane>
			<x>
				<offset bits="0" />
				<offset bits="1" />
				<offset bits="2" />
				<offset bits="3" />
				<offset bits="4" />
				<offset bits="5" />
				<offset bits="6" />
				<offset bits="7" />
			</x>
			<y multiplier="16">
				<offset bits="0" />
				<offset bits="1" />
				<offset bits="2" />
				<offset bits="3" />
				<offset bits="4" />
				<offset bits="5" />
				<offset bits="6" />
				<offset bits="7" />
			</y>
			<stride>128</stride>
		</layout>
	</layouts>

	<regions>
		<region name="Rally Bike/Dash Yarou" length="80000">
			<file name="b45-09" lanes="16/byte">
				<load offset="00000" size="20000" />
			</file>
			<file name="b45-08" lanes="16/byte">
				<load offset="00001" size="20000" />
			</file>
			<file name="b45-07" lanes="16/byte">
				<load offset="40000" size="20000" />
			</file>
			<file name="b45-06" lanes="16/byte">
				<load offset="40001" size="20000" />
			</file>
		</region>

		<region name="Truxton/Tatsujin (Tiles)" length="80000">
			<file name="b65_08" lanes="16/byte">
				<load offset="00000" size="20000" />
			</file>
			<file name="b65_07" lanes="16/byte">
				<load offset="00001" size="20000" />
			</file>
			<file name="b65_06" lanes="16/byte">
				<load offset="40000" size="20000" />
			</file>
			<file name="b65_05" lanes="16/byte">
				<load offset="40001" size="20000" />
			</file>
		</region>

		<region name="Truxton/Tatsujin (Sprites)" length="80000">
			<file name="b65_04" lanes="16/byte">
				<load offset="00000" size="20000" />
			</file>
			<file name="b65_03" lanes="16/byte">
				<load offset="00001" size="20000" />
			</file>
			<file name="b65_02" lanes="16/byte">
				<load offset="40000" size="20000" />
			</file>
			<file name="b65_01" lanes="16/byte">
				<load offset="40001" size="20000" />
			</file>
		</region>

		<region name="Hellfire (Tiles)" length="80000">
			<file name="b90_04.3" lanes="16/byte">
				<load offset="00000" size="20000" />
			</file>
			<file name="b90_05.4" lanes="16/byte">
				<load offset="00001" size="20000" />
			</file>
			<file name="b90_06.5" lanes="16/byte">
				<load offset="40000" size="20000" />
			</file>
			<file name="b90_07.6" lanes="16/byte">
				<load offset="40001" size="20000" />
			</file>
		</region>

		<region name="Hellfire (Sprites)" length="80000">
			<file name="b90_11.10" lanes="16/byte">
				<load offset="00000" size="20000" />
			</file>
			<file name="b90_10.9" lanes="16/byte">
				<load offset="00001" size="20000" />
			</file>
			<file name="b90_09.8" lanes="16/byte">
				<load offset="40000" size="20000" />
			</file>
			<file name="b90_08.7" lanes="16/byte">
				<load offset="40001" size="20000" />
			</file>
		</region>

		<region name="Zero Wing (Tiles)" length="80000">
			<file name="o15-05" lanes="16/byte">
				<load offset="00000" size="20000" />
			</file>
			<file name="o15-06" lanes="16/byte">
				<load offset="00001" size="20000" />
			</file>
			<file name="o15-07" lanes="16/byte">
				<load offset="40000" size="20000" />
			</file>
			<file name="o15-08" lanes="16/byte">
				<load offset="40001" size="20000" />
			</file>
		</region>

		<region name="Zero Wing (Sprites)" length="80000">
			<file name="o15-03" lanes="16/byte">
				<load offset="00000" size="20000" />
			</file>
			<file name="o15-04" lanes="16/byte">
				<load offset="00001" size="20000" />
			</file>
			<file name="o15-01" lanes="16/byte">
				<load offset="40000" size="20000" />
			</file>
			<file name="o15-02" lanes="16/byte">
				<load offset="40001" size="20000" />
			</file>
		</region>

		<region name="Demon's World/Horror Story (Tiles)" length="80000">
			<file name="rom05" lanes="16/byte">
				<load offset="00000" size="20000" />
			</file>
			<file name="rom07" lanes="16/byte">
				<load offset="00001" size="20000" />
			</file>
			<file name="rom06" lanes="16/byte">
				<load offset="40000" size="20000" />
			</file>
			<file name="rom08" lanes="16/byte">
				<load offset="40001" size="20000" />
			</file>
		</region>

		<region name="Demon's World/Horror Story (Sprites)" length="80000">
			<file name="rom01" lanes="16/byte">
				<load offset="00000" size="20000" />
			</file>
			<file name="rom02" lanes="16/byte">
				<load offset="00001" size="20000" />
			</file>
			<file name="rom03" lanes="16/byte">
				<load offset="40000" size="20000" />
			</file>
			<file name="rom04" lanes="16/byte">
				<load offset="40001" size="20000" />
			</file>
		</region>

		<region name="Same! Same! Same!/Fire Shark (Tiles)" length="80000">
			<file name="o17_05.12j" lanes="16/byte">
				<load offset="00000" size="20000" />
			</file>
			<file name="o17_06.13j" lanes="16/byte">
				<load offset="00001" size="20000" />
			</file>
			<file name="o17_07.12l" lanes="16/byte">
				<load offset="40000" size="20000" />
			</file>
			<file name="o17_08.13l" lanes="16/byte">
				<load offset="40001" size="20000" />
			</file>
		</region>

		<region name="Same! Same! Same!/Fire Shark (Sprites)" length="80000">
			<file name="o17_01.1d" lanes="16/byte">
				<load offset="00000" size="20000" />
			</file>
			<file name="o17_02.3d" lanes="16/byte">
				<load offset="00001" size="20000" />
			</file>
			<file name="o17_03.5d" lanes="16/byte">
				<load offset="40000" size="20000" />
			</file>
			<file name="o17_04.7d" lanes="16/byte">
				<load offset="40001" size="20000" />
			</file>
		</region>

		<region name="Out Zone (Tiles)" length="100000">
			<file name="rom5" lanes="16/word">
				<load offset="00000" size="80000" />
			</file>
			<file name="rom6" lanes="16/word">
				<load offset="80000" size="80000" />
			</file>
		</region>

		<region name="Out Zone (Sprites)" length="80000">
			<file name="rom2" lanes="16/byte">
				<load offset="00000" size="20000" />
			</file>
			<file name="rom1" lanes="16/byte">
				<load offset="00001" size="20000" />
			</file>
			<file name="rom3" lanes="16/byte">
				<load offset="40000" size="20000" />
			</file>
			<file name="rom4" lanes="16/byte">
				<load offset="40001" size="20000" />
			</file>
		</region>

		<region name="Vimana (Tiles)" length="80000">
			<file name="vim6" lanes="16/byte">
				<load offset="00000" size="20000" />
			</file>
			<file name="vim5" lanes="16/byte">
				<load offset="00001" size="20000" />
			</file>
			<file name="vim4" lanes="16/byte">
				<load offset="40000" size="20000" />
			</file>
			<file name="vim3" lanes="16/byte">
				<load offset="40001" size="20000" />
			</file>
		</region>

		<region name="Vimana (Sprites)" length="100000">
			<file name="vim1" lanes="16/word">
				<load offset="00000" size="80000" />
			</file>
			<file name="vim2" lanes="16/word">
				<load offset="80000" size="80000" />
			</file>
		</region>
	</regions>
</profile:profile>