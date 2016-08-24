<?xml version="1.0" encoding="utf-8"?>
<profile:profile name="Dooyong Hardware"
    xsi:schemaLocation="http://baddesthacks.net/porno-graphic/profile profile.xsd"
    xmlns:profile="http://baddesthacks.net/porno-graphic/profile"
    xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
>
	<layouts>
		<layout name="Playfield">
			<plane>
				<offset bits="0" />
				<offset bits="1" />
				<offset bits="2" />
				<offset bits="3" />
			</plane>
			<x multiplier="4">
				<offset bits="0" />
				<offset bits="1" />
				<offset bits="2" />
				<offset bits="3" />
				<offset bits="4" />
				<offset bits="5" />
				<offset bits="6" />
				<offset bits="7" />
			</x>
			<y multiplier="8">
				<offset bits="0" />
				<offset bits="4" />
				<offset bits="8" />
				<offset bits="12" />
				<offset bits="16" />
				<offset bits="20" />
				<offset bits="24" />
				<offset bits="28" />
			</y>
			<stride>256</stride>
		</layout>

		<layout name="Motion Graphics?">
			<plane>
				<offset bits="0" />
				<offset bits="1" />
				<offset bits="2" />
				<offset bits="3" />
			</plane>
			<x multiplier="4">
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
			</x>
			<y multiplier="8">
				<offset bits="0" />
				<offset bits="8" />
				<offset bits="16" />
				<offset bits="24" />
				<offset bits="32" />
				<offset bits="40" />
				<offset bits="48" />
				<offset bits="56" />
			</y>
			<stride>512</stride>
		</layout>

		<!-- todo: bootleg version playfield -->
	</layouts>

	<!-- xxx: requires ROMREGION_INVERT -->
	<regions>
		<region name="Playfield" length="60000" invert="true">
			<file name="4n">
				<load offset="000000" size="10000" />
			</file>
			<file name="2n">
				<load offset="010000" size="10000" />
			</file>
			<file name="4s">
				<load offset="020000" size="10000" />
			</file>
			<file name="2s">
				<load offset="030000" size="10000" />
			</file>
			<file name="4u">
				<load offset="040000" size="10000" />
			</file>
			<file name="2u">
				<load offset="050000" size="10000" />
			</file>
		</region>

		<region name="Sprites" length="30000" invert="true">
			<file name="14r">
				<load offset="00000" size="10000" />
			</file>
			<file name="10r">
				<load offset="10000" size="10000" />
			</file>
			<file name="14t">
				<load offset="20000" size="10000" />
			</file>
		</region>
	</regions>
</profile:profile>