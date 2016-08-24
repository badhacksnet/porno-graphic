<?xml version="1.0" encoding="utf-8"?>
<profile:profile name="Side Pocket"
    xsi:schemaLocation="http://baddesthacks.net/porno-graphic/profile profile.xsd"
    xmlns:profile="http://baddesthacks.net/porno-graphic/profile"
    xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
>
	<layouts>
		<layout name="Characters">
			<plane multiplier="8">
				<offset bits="0" />
				<offset bits="32768" />
				<offset bits="65536" />
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

		<layout name="Sprites">
			<plane multiplier="8">
				<offset bits="0" />
				<offset bits="32768" />
				<offset bits="65536" />
			</plane>
			<x>
				<offset bits="128" />
				<offset bits="129" />
				<offset bits="130" />
				<offset bits="131" />
				<offset bits="132" />
				<offset bits="133" />
				<offset bits="134" />
				<offset bits="135" />
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
			<stride>256</stride>
		</layout>
	</layouts>

	<regions>
		<region name="Characters" length="18000">
			<file name="sp_07">
				<load offset="00000" size="8000" />
			</file>
			<file name="sp_06">
				<load offset="08000" size="8000" />
			</file>
			<file name="sp_05">
				<load offset="10000" size="8000" />
			</file>
		</region>

		<region name="Sprites" length="18000">
			<file name="dh01">
				<load offset="00000" size="8000" />
			</file>
			<file name="dh02">
				<load offset="08000" size="8000" />
			</file>
			<file name="dh03">
				<load offset="10000" size="8000" />
			</file>
		</region>
	</regions>
</profile:profile>