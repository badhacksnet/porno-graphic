<?xml version="1.0" encoding="utf-8"?>
<profile:profile name="Double Dragon"
    xsi:schemaLocation="http://baddesthacks.net/porno-graphic/profile profile.xsd"
    xmlns:profile="http://baddesthacks.net/porno-graphic/profile"
    xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
>
	<layouts>
		<layout name="Chars">
			<plane>
				<offset bits="0" />
				<offset bits="2" />
				<offset bits="4" />
				<offset bits="6" />
			</plane>
			<x multiplier="1">
				<offset bits="1" />
				<offset bits="0" />
				<offset bits="65" />
				<offset bits="64" />
				<offset bits="129" />
				<offset bits="128" />
				<offset bits="193" />
				<offset bits="192" />
			</x>
			<y multiplier="8">
				<offset bits="0" />
				<offset bits="1" />
				<offset bits="2" />
				<offset bits="3" />
				<offset bits="4" />
				<offset bits="5" />
				<offset bits="6" />
				<offset bits="7" />
			</y>
			<stride>256</stride>
		</layout>

		<layout name="Tiles">
			<plane>
				<offset bits="0" frac_num="1" frac_den="2" />
				<offset bits="4" frac_num="1" frac_den="2" />
				<offset bits="0" />
				<offset bits="4" />
			</plane>
			<x multiplier="1">
				<offset bits="3" />
				<offset bits="2" />
				<offset bits="1" />
				<offset bits="0" />
				<offset bits="131" />
				<offset bits="130" />
				<offset bits="129" />
				<offset bits="128" />
				<offset bits="259" />
				<offset bits="258" />
				<offset bits="257" />
				<offset bits="256" />
				<offset bits="387" />
				<offset bits="386" />
				<offset bits="385" />
				<offset bits="384" />
			</x>
			<y multiplier="8">
				<offset bits="0" />
				<offset bits="1" />
				<offset bits="2" />
				<offset bits="3" />
				<offset bits="4" />
				<offset bits="5" />
				<offset bits="6" />
				<offset bits="7" />
				<offset bits="8" />
				<offset bits="9" />
				<offset bits="10" />
				<offset bits="11" />
				<offset bits="12" />
				<offset bits="13" />
				<offset bits="14" />
				<offset bits="15" />
			</y>
			<stride>512</stride>
		</layout>
	</layouts>

	<regions>
		<region name="gfx1" length="08000">
			<file name="21j-5">
				<load offset="00000" size="08000" />
			</file>
		</region>
		<region name="gfx2" length="80000">
			<file name="21j-1">
				<load offset="00000" size="10000" />
			</file>
			<file name="21j-b">
				<load offset="10000" size="10000" />
			</file>
			<file name="21j-c">
				<load offset="20000" size="10000" />
			</file>
			<file name="21j-d">
				<load offset="30000" size="10000" />
			</file>
			<file name="21j-e">
				<load offset="40000" size="10000" />
			</file>
			<file name="21j-f">
				<load offset="50000" size="10000" />
			</file>
			<file name="21j-g">
				<load offset="60000" size="10000" />
			</file>
			<file name="21j-h">
				<load offset="70000" size="10000" />
			</file>
		</region>
		<region name="gfx3" length="40000">
			<file name="21j-8">
				<load offset="00000" size="10000" />
			</file>
			<file name="21j-9">
				<load offset="10000" size="10000" />
			</file>
			<file name="21j-i">
				<load offset="20000" size="10000" />
			</file>
			<file name="21j-j">
				<load offset="30000" size="10000" />
			</file>
		</region>
	</regions>
</profile:profile>