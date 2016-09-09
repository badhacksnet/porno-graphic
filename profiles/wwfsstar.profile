<?xml version="1.0" encoding="utf-8"?>
<profile:profile name="WWF Superstars"
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
		<region name="gfx1 (8x8 tiles)" length="20000">
			<file name="24aa-0.58">
				<load offset="00000" size="20000" />
			</file>
		</region>
		<region name="gfx2 (16x16 tiles)" length="200000">
			<file name="c951.114">
				<load offset="000000" size="80000" />
			</file>
			<file name="24j4-0.115">
				<load offset="080000" size="40000" />
			</file>
			<file name="24j5-0.116">
				<load offset="0c0000" size="40000" />
			</file>
			<file name="c950.117">
				<load offset="100000" size="80000" />
			</file>
			<file name="24j2-0.118">
				<load offset="180000" size="40000" />
			</file>
			<file name="24j3-0.119">
				<load offset="1c0000" size="40000" />
			</file>
		</region>
		<region name="gfx3 (16x16 tiles)" length="80000">
			<file name="24j7-0.113">
				<load offset="00000" size="40000" />
			</file>
			<file name="24j6-0.112">
				<load offset="40000" size="40000" />
			</file>
		</region>
	</regions>
</profile:profile>