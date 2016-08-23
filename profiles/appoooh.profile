<?xml version="1.0" encoding="utf-8"?>
<profile:profile name="Appoooh!"
    xsi:schemaLocation="http://baddesthacks.net/porno-graphic/profile profile.xsd"
    xmlns:profile="http://baddesthacks.net/porno-graphic/profile"
    xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
>
	<layouts>
		<layout name="Characters (Appoooh!)">
			<plane multiplier="131072">
				<offset bits="2" />
				<offset bits="1" />
				<offset bits="0" />
			</plane>
			<x>
				<offset bits="7" />
				<offset bits="6" />
				<offset bits="5" />
				<offset bits="4" />
				<offset bits="3" />
				<offset bits="2" />
				<offset bits="1" />
				<offset bits="0" />
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
			<stride>64</stride>
		</layout>

		<layout name="Sprites (Appoooh!)">
			<plane multiplier="131072">
				<offset bits="2" />
				<offset bits="1" />
				<offset bits="0" />
			</plane>
			<x>
				<offset bits="7" />
				<offset bits="6" />
				<offset bits="5" />
				<offset bits="4" />
				<offset bits="3" />
				<offset bits="2" />
				<offset bits="1" />
				<offset bits="0" />
				<offset bits="71" />
				<offset bits="70" />
				<offset bits="69" />
				<offset bits="68" />
				<offset bits="67" />
				<offset bits="66" />
				<offset bits="65" />
				<offset bits="64" />
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
				<offset bits="16" />
				<offset bits="17" />
				<offset bits="18" />
				<offset bits="19" />
				<offset bits="20" />
				<offset bits="21" />
				<offset bits="22" />
				<offset bits="23" />
			</y>
			<stride>256</stride>
		</layout>

		<layout name="Characters (Robo Wres 2001)">
			<plane>
				<offset fracnum="2" fracden="3" />
				<offset fracnum="1" fracden="3" />
				<offset fracnum="0" fracden="3" />
			</plane>
			<x>
				<offset bits="7" />
				<offset bits="6" />
				<offset bits="5" />
				<offset bits="4" />
				<offset bits="3" />
				<offset bits="2" />
				<offset bits="1" />
				<offset bits="0" />
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
			<stride>64</stride>
		</layout>

		<layout name="Sprites (Robo Wres 2001)">
			<plane>
				<offset fracnum="2" fracden="3" />
				<offset fracnum="1" fracden="3" />
				<offset fracnum="0" fracden="3" />
			</plane>
			<x>
				<offset bits="7" />
				<offset bits="6" />
				<offset bits="5" />
				<offset bits="4" />
				<offset bits="3" />
				<offset bits="2" />
				<offset bits="1" />
				<offset bits="0" />
				<offset bits="71" />
				<offset bits="70" />
				<offset bits="69" />
				<offset bits="68" />
				<offset bits="67" />
				<offset bits="66" />
				<offset bits="65" />
				<offset bits="64" />
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
				<offset bits="16" />
				<offset bits="17" />
				<offset bits="18" />
				<offset bits="19" />
				<offset bits="20" />
				<offset bits="21" />
				<offset bits="22" />
				<offset bits="23" />
			</y>
			<stride>256</stride>
		</layout>
	</layouts>

	<regions>
		<region name="gfx1 (Appoooh!)" length="C000">
			<file name="epr-5895">
				<load offset="00000" size="4000" />
			</file>
			<file name="epr-5896">
				<load offset="04000" size="4000" />
			</file>
			<file name="epr-5897">
				<load offset="08000" size="4000" />
			</file>
		</region>

		<region name="gfx2 (Appoooh!)" length="C000">
			<file name="epr-5898">
				<load offset="00000" size="4000" />
			</file>
			<file name="epr-5899">
				<load offset="04000" size="4000" />
			</file>
			<file name="epr-5900">
				<load offset="08000" size="4000" />
			</file>
		</region>

		<region name="gfx1 (Robo Wres 2001)" length="18000">
			<file name="epr-7544.7h">
				<load offset="00000" size="8000" />
			</file>
			<file name="epr-7545.6h">
				<load offset="08000" size="8000" />
			</file>
			<file name="epr-7546.5h">
				<load offset="10000" size="8000" />
			</file>
		</region>

		<region name="gfx2 (Robo Wres 2001)" length="18000">
			<file name="epr-7547.7d">
				<load offset="00000" size="8000" />
			</file>
			<file name="epr-7548.6d">
				<load offset="08000" size="8000" />
			</file>
			<file name="epr-7549.5d">
				<load offset="10000" size="8000" />
			</file>
		</region>
	</regions>
</profile:profile>