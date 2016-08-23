<?xml version="1.0" encoding="utf-8"?>
<profile:profile name="Arkanoid"
    xsi:schemaLocation="http://baddesthacks.net/porno-graphic/profile profile.xsd"
    xmlns:profile="http://baddesthacks.net/porno-graphic/profile"
    xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
>
	<layouts>
		<layout name="Tiles">
			<plane multiplier="262144">
				<offset bits="2" />
				<offset bits="1" />
				<offset bits="0" />
			</plane>
			<x multiplier="1">
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
	</layouts>

	<regions>
		<region name="Tiles" length="18000">
			<file name="ic64">
				<load offset="00000" size="8000" />
			</file>
			<file name="ic63">
				<load offset="08000" size="8000" />
			</file>
			<file name="ic62">
				<load offset="10000" size="8000" />
			</file>
		</region>
	</regions>
</profile:profile>