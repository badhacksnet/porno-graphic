<?xml version="1.0" encoding="utf-8"?>
<profile:profile name="Dooyong Hardware"
    xsi:schemaLocation="http://baddesthacks.net/porno-graphic/profile profile.xsd"
    xmlns:profile="http://baddesthacks.net/porno-graphic/profile"
    xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
>
	<layouts>
		<layout name="Contra Graphics">
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
			<y multiplier="32">
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
	</layouts>

	<regions>
		<region name="Contra Graphics 1" length="80000">
			<file name="7d" lanes="16/byte">
				<load offset="00000" size="40000" />
			</file>
			<file name="7f" lanes="16/byte">
				<load offset="00001" size="40000" />
			</file>
		</region>
		<region name="Contra Graphics 2" length="80000">
			<file name="16d" lanes="16/byte">
				<load offset="00000" size="40000" />
			</file>
			<file name="16f" lanes="16/byte">
				<load offset="00001" size="40000" />
			</file>
		</region>
	</regions>
</profile:profile>